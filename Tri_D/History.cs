﻿using MySql.Data.MySqlClient;
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
            historyTable.CellEndEdit += historyTable_CellEndEdit;
            searchTextbox.TextChanged += SearchTextbox_TextChanged;


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

                string ownerID = reader["ownerID"].ToString();

                // Check if "time_out" is NULL
                TimeSpan? timeOut = reader["timeout"] != DBNull.Value ? (TimeSpan?)reader["timeout"] : null;

                // Calculate the duration if timeOut is not null
                TimeSpan duration = timeOut.HasValue ? CalculateDuration(timeIn, timeOut.Value) : TimeSpan.Zero;

                // Add the data to the DataGridView
                historyTable.Rows.Add(
                    reader["owner"].ToString(),
                    ownerID,       // Display the ownerID
                    reader["type"].ToString(),
                    date.ToString("yyyy-MM-dd"),  // Format date as needed
                    timeIn.ToString(@"hh\:mm"),   // Format time as HH:mm
                    timeOut.HasValue ? timeOut.Value.ToString(@"hh\:mm") : "N/A",  // Handle NULL timeOut
                    duration.ToString(@"hh\:mm")  // Display the calculated duration
                );

                // Store the data for later update (if timeOut is available)
                if (timeOut.HasValue)
                {
                    updateData.Add(new Tuple<DateTime, TimeSpan, TimeSpan, string, string>(date, timeIn, timeOut.Value, ownerID, duration.ToString(@"hh\:mm")));
                }
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


        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text.ToLower(); // Get the search text and convert it to lowercase

            // Loop through the rows in the historyTable
            foreach (DataGridViewRow row in historyTable.Rows)
            {
                // Check if the row should be visible based on the search text
                bool isVisible = row.Cells["ownerHeader"].Value.ToString().ToLower().Contains(searchText) ||
                                 row.Cells["OwnerID"].Value.ToString().ToLower().Contains(searchText) ||
                                 row.Cells["typeHeader"].Value.ToString().ToLower().Contains(searchText) ||
                                 row.Cells["dateHeader"].Value.ToString().Contains(searchText) ||
                                 row.Cells["timeinHeader"].Value.ToString().Contains(searchText) ||
                                 row.Cells["timeoutHeader"].Value.ToString().Contains(searchText) ||
                                 row.Cells["durationHeader"].Value.ToString().Contains(searchText);

                // Set the row visibility
                row.Visible = isVisible;
            }
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
        private void historyTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (historyTable.Columns[e.ColumnIndex].Name == "timeinHeader")
            {
                int rowIndex = e.RowIndex;

                string ownerID = historyTable.Rows[rowIndex].Cells["OwnerID"].Value.ToString(); // Owner ID
                string dateString = historyTable.Rows[rowIndex].Cells["dateHeader"].Value.ToString(); // Date
                string newTimeInString = historyTable.Rows[rowIndex].Cells["timeinHeader"].Value.ToString(); // New Time-In

                // Validate the new value (ensure it's a valid time)
                if (TimeSpan.TryParseExact(newTimeInString, @"hh\:mm", null, out TimeSpan newTimeIn))
                {
                    DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);

                    // Step 1: Update `time_in` in the database
                    string updateQuery = @"
                UPDATE history 
                SET time_in = @newTimeIn 
                WHERE owner_id = @ownerID 
                AND date = @date";

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@newTimeIn", newTimeIn.ToString(@"hh\:mm\:ss"));
                        updateCmd.Parameters.AddWithValue("@ownerID", ownerID);
                        updateCmd.Parameters.AddWithValue("@date", date);

                        try
                        {
                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Step 2: Fetch `time_out` for recalculating duration
                                string fetchTimeOutQuery = @"
                            SELECT time_out FROM history 
                            WHERE owner_id = @ownerID 
                            AND date = @date";

                                using (MySqlCommand fetchCmd = new MySqlCommand(fetchTimeOutQuery, connection))
                                {
                                    fetchCmd.Parameters.AddWithValue("@ownerID", ownerID);
                                    fetchCmd.Parameters.AddWithValue("@date", date);

                                    object timeOutObj = fetchCmd.ExecuteScalar();
                                    if (timeOutObj != DBNull.Value)
                                    {
                                        TimeSpan timeOut = TimeSpan.Parse(timeOutObj.ToString());

                                        // Step 3: Calculate the new duration
                                        TimeSpan newDuration = CalculateDuration(newTimeIn, timeOut);

                                        // Update duration in the database
                                        string updateDurationQuery = @"
                                    UPDATE history 
                                    SET duration = @newDuration 
                                    WHERE owner_id = @ownerID 
                                    AND date = @date";

                                        using (MySqlCommand updateDurationCmd = new MySqlCommand(updateDurationQuery, connection))
                                        {
                                            updateDurationCmd.Parameters.AddWithValue("@newDuration", newDuration.ToString(@"hh\:mm\:ss"));
                                            updateDurationCmd.Parameters.AddWithValue("@ownerID", ownerID);
                                            updateDurationCmd.Parameters.AddWithValue("@date", date);

                                            updateDurationCmd.ExecuteNonQuery();

                                            // Update duration in the DataGridView
                                            historyTable.Rows[rowIndex].Cells["durationHeader"].Value = newDuration.ToString(@"hh\:mm");
                                            MessageBox.Show("Time-In and Duration updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Time-Out is not set for this record. Duration cannot be calculated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching record found to update. Check the input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating Time-In: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Time format. Please use HH:mm.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



            if (historyTable.Columns[e.ColumnIndex].Name == "timeoutHeader")
            {
                int rowIndex = e.RowIndex;

                string ownerID = historyTable.Rows[rowIndex].Cells["OwnerID"].Value.ToString(); // Owner ID
                string dateString = historyTable.Rows[rowIndex].Cells["dateHeader"].Value.ToString(); // Date
                string newTimeOutString = historyTable.Rows[rowIndex].Cells["timeoutHeader"].Value.ToString(); // New Time-Out

                // Validate the new value (ensure it's a valid time)
                if (TimeSpan.TryParseExact(newTimeOutString, @"hh\:mm", null, out TimeSpan newTimeOut))
                {
                    DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);

                    // Step 1: Update `time_out` in the database
                    string updateQuery = @"
                        UPDATE history 
                        SET time_out = @newTimeOut 
                        WHERE owner_id = @ownerID 
                        AND date = @date";

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@newTimeOut", newTimeOut.ToString(@"hh\:mm\:ss"));
                        updateCmd.Parameters.AddWithValue("@ownerID", ownerID);
                        updateCmd.Parameters.AddWithValue("@date", date);

                        try
                        {
                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Step 2: Fetch `time_in` for recalculating duration
                                string fetchTimeInQuery = @"
                        SELECT time_in FROM history 
                        WHERE owner_id = @ownerID 
                        AND date = @date";

                                using (MySqlCommand fetchCmd = new MySqlCommand(fetchTimeInQuery, connection))
                                {
                                    fetchCmd.Parameters.AddWithValue("@ownerID", ownerID);
                                    fetchCmd.Parameters.AddWithValue("@date", date);

                                    object timeInObj = fetchCmd.ExecuteScalar();
                                    if (timeInObj != DBNull.Value)
                                    {
                                        TimeSpan timeIn = TimeSpan.Parse(timeInObj.ToString());

                                        // Step 3: Calculate the new duration
                                        TimeSpan newDuration = CalculateDuration(timeIn, newTimeOut);

                                        // Update duration in the database
                                        string updateDurationQuery = @"
                                UPDATE history 
                                SET duration = @newDuration 
                                WHERE owner_id = @ownerID 
                                AND date = @date";

                                        using (MySqlCommand updateDurationCmd = new MySqlCommand(updateDurationQuery, connection))
                                        {
                                            updateDurationCmd.Parameters.AddWithValue("@newDuration", newDuration.ToString(@"hh\:mm\:ss"));
                                            updateDurationCmd.Parameters.AddWithValue("@ownerID", ownerID);
                                            updateDurationCmd.Parameters.AddWithValue("@date", date);

                                            updateDurationCmd.ExecuteNonQuery();

                                            // Update duration in the DataGridView
                                            historyTable.Rows[rowIndex].Cells["durationHeader"].Value = newDuration.ToString(@"hh\:mm");
                                            MessageBox.Show("Time-Out and Duration updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Time-In is not set for this record. Duration cannot be calculated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching record found to update. Check the input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating Time-Out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Time format. Please use HH:mm.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                int current_x = historyPanel.Location.X - 10;
                historyPanel.Location = new Point(current_x, 88);
                if (historyPanel.Location.X >= 297)
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
                int current_x = historyPanel.Location.X + 10;
                historyPanel.Location = new Point(current_x, 88);
                if (historyPanel.Location.X <= 12)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            if(this.Width == 772)
            {
                this.Width = 972;
            }
            else if(this.Width == 972)
            { 
                this.Width = 772; }
            
            
        }
    }
}
