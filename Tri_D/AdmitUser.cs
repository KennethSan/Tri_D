using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tri_D
{
    public partial class AdmitUser : Form
    {

        MySqlConnection connection = connectionDB.GetConnection();
        String current_admitting_user;
        String current_admitting_plate;
        String current_owner_id;

        public AdmitUser()
        {
            InitializeComponent();
            load_queued_drivers();
            load_available_slots();
            load_admins();

        }

        private void load_queued_drivers()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string load_queued_query = @"SELECT h.plate_number, h.owner_id, COALESCE(e.first_name, s.first_name) AS first_name, COALESCE(e.last_name, s.last_name) AS last_name FROM history h LEFT JOIN employees e ON h.owner_id = e.employee_number LEFT JOIN students s ON h.owner_id = s.student_number WHERE h.time_out IS NULL AND h.slot_number IS NULL;";
                MySqlCommand cmd = new MySqlCommand(load_queued_query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string plate_number = reader["plate_number"].ToString();
                    string owner_id = reader["owner_id"].ToString();

                    string full_name_plate = first_name + " " + last_name + " | " + plate_number + " | " + owner_id;
                    combo_queued_drivers.Items.Add(full_name_plate);
                }

                reader.Close();
            }
        }

        private void load_available_slots()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string load_queued_query = @"SELECT slot_number FROM parkingslotmotorcycle UNION SELECT slot_number FROM parkingslot WHERE status='vacant';";
                MySqlCommand cmd = new MySqlCommand(load_queued_query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string slot_number = reader["slot_number"].ToString();
                    combo_choose_slot.Items.Add(slot_number);
                }

                reader.Close();
            }
        }

        private void load_admins()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string load_queued_query = @"SELECT username FROM account";
                MySqlCommand cmd = new MySqlCommand(load_queued_query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string username_admin = reader["username"].ToString();
                    combo_admin.Items.Add(username_admin);
                }

                reader.Close();
            }
        }

        private void admit_driver()
        {

            String slot_number = combo_choose_slot.SelectedItem.ToString();
            String admin_name = combo_admin.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string admit_driver_query = @"UPDATE history SET slot_number=@slot_number, admin_name=@admin_name WHERE plate_number=@plate_number AND slot_number IS NULL;";
                MySqlCommand cmd = new MySqlCommand(admit_driver_query, conn);

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@slot_number", slot_number);
                cmd.Parameters.AddWithValue("@admin_name", admin_name);
                cmd.Parameters.AddWithValue("@plate_number", current_admitting_plate);
                cmd.ExecuteNonQuery();
            }

            if (slot_number.Contains("M"))
            {
                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    string update_slots_query = @"UPDATE parkingslotmotorcycle SET status='occupied', user_id=@user_id WHERE slot_number=@slot_number";
                    MySqlCommand cmd = new MySqlCommand(update_slots_query, conn);

                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@slot_number", slot_number);
                    cmd.Parameters.AddWithValue("@user_id", current_owner_id);
                    cmd.ExecuteNonQuery();
                }
            } else
            {
                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    string update_slots_query = @"UPDATE parkingslot SET status='occupied', user_id=@user_id WHERE slot_number=@slot_number";
                    MySqlCommand cmd = new MySqlCommand(update_slots_query, conn);

                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@slot_number", slot_number);
                    cmd.Parameters.AddWithValue("@user_id", current_owner_id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void combo_queued_drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_driver = combo_queued_drivers.SelectedItem.ToString();
            string[] selected_driver_parts = selected_driver.Split(new string[] { " | " }, StringSplitOptions.None);
            current_admitting_user = selected_driver_parts[0];
            current_admitting_plate = selected_driver_parts[1];
            current_owner_id = selected_driver_parts[2];
        }

        private void admit_button_Click(object sender, EventArgs e)
        {
            admit_driver();
            combo_queued_drivers.Items.Clear();
            load_queued_drivers();
            combo_choose_slot.Items.Clear();
            load_available_slots();
            MessageBox.Show("Driver admitted.");

        }
    }
}
