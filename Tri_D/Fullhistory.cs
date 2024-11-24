using LiveChartsCore.Drawing;
using LiveChartsCore.Themes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tri_D.History;

namespace Tri_D
{
    public partial class Fullhistory : Form
    {
        Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        private float scaleFactor;
        private Size originalTableSize;
        private Size originalPanelSize;

        public Fullhistory()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            originalTableSize = fullHistoryTable.Size;
            originalPanelSize = fulltbl.Size;
        }
        public void GetPrintArea(Panel pnl)
        {
            // Update Bitmap size to match panel's current size
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
            {
                if (MemoryImage != null)
                {
                    e.Graphics.DrawImage(MemoryImage, 0, 0);
                    base.OnPaint(e);
                }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the printable area
            Rectangle pagearea = e.PageBounds;

            // Calculate scale factor
            float scaleWidth = pagearea.Width / (float)MemoryImage.Width;
            float scaleHeight = pagearea.Height / (float)MemoryImage.Height;
            scaleFactor = Math.Min(scaleWidth, scaleHeight);

            // Center and draw the scaled image
            e.Graphics.DrawImage(MemoryImage,
                (pagearea.Width - MemoryImage.Width * scaleFactor) / 2,  // Center horizontally
                0,                                                      // Start from the top
                MemoryImage.Width * scaleFactor,
                MemoryImage.Height * scaleFactor);
        }
        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);  // Capture the table image
            previewdlg.Document = printDocument1;  // Set the print document
            previewdlg.ShowDialog();  // Show the print preview

        }

        private void Fullhistory_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = connectionDB.GetConnection();

            ownerID.Text = OwnerDetails.OwnerID;
            fullnameResultlbl.Text = OwnerDetails.OwnerName;
            typeResultlbl.Text = OwnerDetails.OwnerType;    
            string queryHistory = @" SELECT v.type, h.plate_number, h.date, h.time_in AS timein, h.time_out AS timeout, h.duration, h.reason, h.slot_number, h.admin_name AS duty FROM history h LEFT JOIN vehicles v ON h.plate_number = v.plate_number LEFT JOIN students s ON h.owner_id = s.student_number LEFT JOIN employees e ON h.owner_id = e.employee_number WHERE h.owner_id = @OwnerID; ";

            using (MySqlCommand cmd = new MySqlCommand(queryHistory, connection))
            {
                cmd.Parameters.AddWithValue("@OwnerID", ownerID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["date"]);
                    TimeSpan timeIn = (TimeSpan)reader["timein"];

                    // Check if "time_out" is NULL
                    TimeSpan? timeOut = reader["timeout"] != DBNull.Value ? (TimeSpan?)reader["timeout"] : null;

                    // Get the duration directly from database (if nullable, handle it)
                    string duration = reader["duration"] != DBNull.Value ? reader["duration"].ToString() : "N/A";

                    // Add the row to your existing DataGridView
                    fullHistoryTable.Rows.Add(
                        reader["type"].ToString(),                // Owner type
                        reader["plate_number"].ToString(),        // Plate number
                        date.ToString("yyyy-MM-dd"),              // Date formatted
                        timeIn.ToString(@"hh\:mm"),               // Time in
                        timeOut.HasValue ? timeOut.Value.ToString(@"hh\:mm") : "N/A", // Time out (handle NULL)
                        duration,                                 // Duration directly from database (with NULL check)
                        reader["reason"].ToString(),              // Reason
                        reader["slot_number"].ToString(),         // Slot number
                        reader["duty"].ToString()                 // Guard notes/duty
                    );
                }

                reader.Close();
            }



        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printBtn.Visible = false;
            AdjustTableHeightForRows();

            Print(this.fulltbl);
            ResetTableAndPanelSize();
            printBtn.Visible = true;



        }
        private void ResetTableAndPanelSize()
        {
            fullHistoryTable.Size = originalTableSize;
            fulltbl.Size = originalPanelSize;
        }

        private void AdjustTableHeightForRows()
        {
            int maxVisibleRows = 8; // Maximum rows before stretching
            int rowCount = fullHistoryTable.Rows.Count;

            if (rowCount > maxVisibleRows)
            {
                int rowHeight = fullHistoryTable.RowTemplate.Height;
                int headerHeight = fullHistoryTable.ColumnHeadersHeight;

                // Compute the desired height for the table
                int newHeight = headerHeight + (rowHeight * rowCount);

                // Set the table and panel height
                fullHistoryTable.Height = newHeight;
                fulltbl.Height = newHeight + 20; // Add some padding for the panel
            }
        }


        private void Details_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
        }

        private void details1_Load(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Hide();
        }

        /*private void printButton_Click(object sender, EventArgs e)
        {
            Print(this.fulltbl);
        }*/
    }
}
