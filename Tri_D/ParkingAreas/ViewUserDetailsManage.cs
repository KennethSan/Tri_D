using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tri_D.ParkingAreas
{
    public partial class ViewUserDetailsManage : Form
    {
        MySqlConnection connection = connectionDB.GetConnection();
        String slot_number_refresh;
        public ViewUserDetailsManage(String slot_number)
        {
            InitializeComponent();
            load_details(slot_number);
            slot_number_refresh = slot_number;
            refresh_duration.Start();
        }

        public void load_details(String slot_number)
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string admit_driver_query = @"SELECT 
                        CONCAT(s.first_name, ' ', s.last_name) AS full_name, 
                        h.time_in, 
                        h.user_type,
                        h.plate_number, 
                        s.student_number AS identifier,
                        s.email
                    FROM 
                        parkingslot ps
                    JOIN 
                        history h ON ps.user_id = h.owner_id
                    JOIN 
                        students s ON h.owner_id = s.student_number
                    WHERE 
                        h.time_out IS NULL AND h.slot_number = @slot_number

                    UNION ALL

                    SELECT 
                        g.full_name, 
                        h.time_in, 
                        h.user_type,
                        h.plate_number, 
                        g.guest_number AS identifier,
                        g.email
                    FROM 
                        parkingslot ps
                    JOIN 
                        history h ON ps.user_id = h.owner_id
                    JOIN 
                        guests g ON h.owner_id = g.guest_number
                    WHERE 
                        h.time_out IS NULL AND ps.slot_number = @slot_number

                    UNION ALL

                    SELECT 
                        CONCAT(e.first_name, ' ', e.last_name) AS full_name, 
                        h.time_in, 
                        h.user_type,
                        h.plate_number, 
                        e.employee_number AS identifier,
                        e.email
                    FROM 
                        parkingslot ps
                    JOIN 
                        history h ON ps.user_id = h.owner_id
                    JOIN 
                        employees e ON h.owner_id = e.employee_number
                    WHERE 
                        h.time_out IS NULL AND ps.slot_number = @slot_number;";

                MySqlCommand cmd = new MySqlCommand(admit_driver_query, conn);

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@slot_number", slot_number);
                MySqlDataReader reader = cmd.ExecuteReader();

                string full_name;
                string time_in;
                string user_type;
                string plate_number;
                string owner_id;
                string email;

                while (reader.Read())
                {
                    full_name = reader["full_name"].ToString();
                    time_in = reader["time_in"].ToString();
                    user_type = reader["user_type"].ToString();
                    plate_number = reader["plate_number"].ToString();
                    owner_id = reader["identifier"].ToString();
                    email = reader["email"].ToString();

                    

                    string time_out = DateTime.Now.ToString("HH:mm:ss");

                    // Convert strings to TimeSpan
                    TimeSpan inTime = TimeSpan.Parse(time_in);
                    TimeSpan outTime = TimeSpan.Parse(time_out);

                    // Calculate duration
                    TimeSpan duration = outTime - inTime;
                    String duration_str = duration.ToString();

                    label_duration.Text = duration_str;
                    label_full_name.Text = full_name;
                    label_email.Text = email;
                    label_user_type.Text = user_type;
                    label_slot_number.Text = slot_number;
                    label_owner_id.Text = owner_id;
                    label_plate.Text = plate_number;
                    label_time_in.Text = time_in;
                }

                
                reader.Close();

                


            }
        }

        private void refresh_duration_Tick(object sender, EventArgs e)
        {
            load_details(slot_number_refresh);
        }
    }
}
