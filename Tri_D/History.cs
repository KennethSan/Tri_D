using MySql.Data.MySqlClient;
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

namespace Tri_D
{
    public partial class History : Form
    {
        bool sidebarExpand;
        MySqlConnection connection = connectionDB.GetConnection();
        public class OwnerDetails
        {
            // Static property to hold the selected owner ID
            public static string OwnerID { get; set; }
            public static string OwnerName { get; set; }
            public static string OwnerType { get; set; }

        }

        public History()
        {
            InitializeComponent();
            historyTable.CellClick += historyTable_CellClick;
            string queryHistory = @"
    SELECT h.date, h.time_in AS timein, h.time_out AS timeout, 
           CONCAT(s.first_name, ' ', s.last_name) AS owner, 'Student' AS type, h.owner_id AS ownerID 
    FROM history h 
    JOIN students s ON h.owner_id = s.student_number 
    UNION ALL 
    SELECT h.date, h.time_in AS timein, h.time_out AS timeout, 
           CONCAT(e.first_name, ' ', e.last_name) AS owner, 'Employee' AS type, h.owner_id AS ownerID 
    FROM history h 
    JOIN employees e ON h.owner_id = e.employee_number";

            MySqlCommand cmd = new MySqlCommand(queryHistory, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            // Create a list to hold the update data
            List<Tuple<DateTime, TimeSpan, TimeSpan, string, string>> updateData = new List<Tuple<DateTime, TimeSpan, TimeSpan, string, string>>();

            while (reader.Read())
            {
                DateTime date = Convert.ToDateTime(reader["date"]);
                TimeSpan timeIn = (TimeSpan)reader["timein"];
                TimeSpan timeOut = (TimeSpan)reader["timeout"];
                string ownerID = reader["ownerID"].ToString();

                // Calculate the duration
                TimeSpan duration = CalculateDuration(timeIn, timeOut);

                // Add the data to the DataGridView
                historyTable.Rows.Add(
                    reader["owner"].ToString(),
                    ownerID,       // Display the ownerID
                    reader["type"].ToString(),
                    date.ToString("yyyy-MM-dd"),  // Format date as needed
                    timeIn.ToString(@"hh\:mm"),   // Format time as HH:mm
                    timeOut.ToString(@"hh\:mm"),  // Format time as HH:mm
                    duration.ToString(@"hh\:mm")  // Display the calculated duration
                );

                // Store the data for later update
                updateData.Add(new Tuple<DateTime, TimeSpan, TimeSpan, string, string>(date, timeIn, timeOut, ownerID, duration.ToString(@"hh\:mm")));
            }

            reader.Close();  // Close the reader after finishing reading

            // Now perform the updates after all data is read
            foreach (var data in updateData)
            {
                DateTime date = data.Item1;
                TimeSpan timeIn = data.Item2;
                TimeSpan timeOut = data.Item3;
                string ownerID = data.Item4;
                string duration = data.Item5;

                // Update the specific record in the database
                string updateQuery = @"
        UPDATE history 
        SET duration = @duration 
        WHERE owner_id = @ownerID 
        AND date = @date 
        AND time_in = @timeIn"; // Use time_in to specifically identify the record

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@duration", duration);  // Set the calculated duration
                updateCmd.Parameters.AddWithValue("@ownerID", ownerID);
                updateCmd.Parameters.AddWithValue("@date", date);
                updateCmd.Parameters.AddWithValue("@timeIn", timeIn);

                updateCmd.ExecuteNonQuery(); // Execute the update
            }
        }

            private void History_Load(object sender, EventArgs e)
        {
            sidebar.Width = sidebar.MinimumSize.Width;
        }
        private void historyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the details button
            if (e.RowIndex >= 0 && historyTable.Columns[e.ColumnIndex].Name == "detailsButton")
            {
                // Get the OwnerID from the corresponding row
                string ownerID = historyTable.Rows[e.RowIndex].Cells["OwnerID"].Value.ToString();
                string ownerName = historyTable.Rows[e.RowIndex].Cells["ownerHeader"].Value.ToString();
                string ownerType = historyTable.Rows[e.RowIndex].Cells["typeHeader"].Value.ToString();
         

                // Set the static property in OwnerDetails
                OwnerDetails.OwnerID = ownerID;
                OwnerDetails.OwnerName = ownerName;
                OwnerDetails.OwnerType = ownerType;
                // Open the Fullhistory form
                Fullhistory fullHistoryForm = new Fullhistory();

                // Hide the current form
                this.Hide();

                // Show the Fullhistory form
                fullHistoryForm.ShowDialog();

             
            }
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide(); // Hide the login form
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private TimeSpan CalculateDuration(TimeSpan timeIn, TimeSpan timeOut)
        {
            // Ensure timeOut is later than timeIn, in case timeOut is after midnight or the timeIn is earlier
            if (timeOut < timeIn)
            {
                // Add a day to timeOut if it's before timeIn (i.e., spans midnight)
                timeOut = timeOut.Add(TimeSpan.FromDays(1));
            }

            return timeOut - timeIn; // Calculate and return the duration
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

       
    }
}
