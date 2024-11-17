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
        public History()
        {
            InitializeComponent();

            string queryHistory = @" SELECT h.date, h.time_in AS timein, h.time_out AS timeout, CONCAT(s.first_name, ' ', s.last_name) AS owner, 'Student' AS type FROM history h JOIN students s ON h.owner_id = s.student_number UNION ALL SELECT h.date, h.time_in AS timein, h.time_out AS timeout, CONCAT(e.first_name, ' ', e.last_name) AS owner, 'Employee' AS type FROM history h JOIN employees e ON h.owner_id = e.employee_number";

            MySqlCommand cmd = new MySqlCommand(queryHistory, connection);
            MySqlDataReader reader =  cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime date = Convert.ToDateTime(reader["date"]);

                // Handle potential nulls for time_in and time_out
                TimeSpan? timeIn = reader["timein"] != DBNull.Value ? (TimeSpan)reader["timein"] : (TimeSpan?)null;
                TimeSpan? timeOut = reader["timeout"] != DBNull.Value ? (TimeSpan)reader["timeout"] : (TimeSpan?)null;

                string duration = timeIn.HasValue && timeOut.HasValue
                    ? CalculateDuration(timeIn.Value, timeOut.Value).ToString(@"hh\:mm")
                    : "N/A"; // Indicate that duration cannot be calculated

                historyTable.Rows.Add(
                    reader["owner"].ToString(),
                    reader["type"].ToString(),
                    date.ToString("yyyy-MM-dd"),    // Format date as needed
                    timeIn.HasValue ? timeIn.Value.ToString(@"hh\:mm") : "N/A",  // Handle null time_in
                    timeOut.HasValue ? timeOut.Value.ToString(@"hh\:mm") : "N/A", // Handle null time_out
                    duration
                );
            }
            reader.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            sidebar.Width = sidebar.MinimumSize.Width;
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
