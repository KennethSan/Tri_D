using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tri_D
{
    public partial class ExitUser : Form
    {

        MySqlConnection connection = connectionDB.GetConnection();

        public ExitUser()
        {
            InitializeComponent();
            load_drivers();

        }

        private void load_drivers()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string load_queued_query = @"SELECT 
                        h.plate_number,
                        h.slot_number,
                        h.time_in,
                        COALESCE(e.first_name, s.first_name) AS first_name,
                        COALESCE(e.last_name, s.last_name) AS last_name,
                        CASE 
                            WHEN e.employee_number IS NOT NULL THEN 'Employee'
                            WHEN s.student_number IS NOT NULL THEN 'Student'
                            ELSE 'Unknown'
                        END AS owner_type,
                        h.owner_id AS reference_number
                    FROM 
                        history h
                    LEFT JOIN 
                        employees e ON h.owner_id = e.employee_number
                    LEFT JOIN 
                        students s ON h.owner_id = s.student_number
                    WHERE 
                        time_out IS NULL AND slot_number IS NOT NULL";
                MySqlCommand cmd = new MySqlCommand(load_queued_query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string plate_number = reader["plate_number"].ToString();
                    string slot_number = reader["slot_number"].ToString();
                    string time_in = reader["time_in"].ToString();

                    string display = first_name + last_name + " | " + plate_number + " | " + slot_number + " | " + time_in;
                    combo_drivers.Items.Add(display);
                }

                reader.Close();


            }
        }

        private void update_slots()
        {
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            string selected_driver = combo_drivers.SelectedItem.ToString();
            string[] selected_driver_parts = selected_driver.Split(new string[] { " | " }, StringSplitOptions.None);
            string full_name = selected_driver_parts[0];
            string plate_number = selected_driver_parts[1];
            string slot_number = selected_driver_parts[2];
            string time_in = selected_driver_parts[3];

            
            string time_out = DateTime.Now.ToString("HH:mm:ss");

            // Convert strings to TimeSpan
            TimeSpan inTime = TimeSpan.Parse(time_in);
            TimeSpan outTime = TimeSpan.Parse(time_out);

            // Calculate duration
            TimeSpan duration = outTime - inTime;

            if (slot_number.Contains("A"))
            {
                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    string update_slots_query = @"UPDATE parkingslot SET status='vacant' WHERE slot_number=@slot_number";
                    MySqlCommand cmd = new MySqlCommand(update_slots_query, conn);

                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@slot_number", slot_number);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    string update_slots_query = @"UPDATE parkingslotmotorcycle SET status='vacant' WHERE slot_number=@slot_number";
                    MySqlCommand cmd = new MySqlCommand(update_slots_query, conn);

                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@slot_number", slot_number);
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string load_queued_query = @"UPDATE history SET time_out=@time_out, duration=@duration WHERE plate_number=@plate_number AND time_out IS NULL;";
                MySqlCommand cmd = new MySqlCommand(load_queued_query, conn);

                cmd.Parameters.AddWithValue("@time_out", time_out);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@plate_number", plate_number);

                cmd.ExecuteNonQuery();


                MessageBox.Show("User exited");
                combo_drivers.Items.Clear();
                load_drivers();


            }



        }
    }
}
