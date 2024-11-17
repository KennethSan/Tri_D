using LiveChartsCore.Themes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tri_D.History;

namespace Tri_D
{
    public partial class Fullhistory : Form
    {
        public Fullhistory()
        {
            InitializeComponent();
           

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
                    TimeSpan timeOut = (TimeSpan)reader["timeout"];
                    string duration = reader["duration"].ToString(); // Get the duration directly

                    // Add the row to your existing DataGridView
                    fullHistoryTable.Rows.Add(
                        reader["type"].ToString(),             // Owner type
                        reader["plate_number"].ToString(),    // Plate number
                        date.ToString("yyyy-MM-dd"),          // Date formatted
                        timeIn.ToString(@"hh\:mm"),           // Time in
                        timeOut.ToString(@"hh\:mm"),          // Time out
                        duration,                             // Duration directly from database
                        reader["reason"].ToString(),          // Reason
                        reader["slot_number"].ToString(),     // Slot number
                        reader["duty"].ToString()             // Guard notes/duty
                    );
                }

                reader.Close();
            }


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
