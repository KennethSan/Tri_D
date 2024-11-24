using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tri_D.ParkingAreas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tri_D
{
    public partial class Manage : Form
    {
        bool sidebarExpand;
        MySqlConnection connection = connectionDB.GetConnection();
        public Manage()
        {
            InitializeComponent();
            vehiclesTable.CellClick += vehiclesTable_CellClick;
            panel_verified.Visible = false;
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            sidebar.Width = sidebar.MinimumSize.Width;

            CanteenSide default_parking = new CanteenSide();
            addUserControl(default_parking);
            default_parking.update_slot_buttons();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void vehiclesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is within bounds (avoid index out of range errors)
            if (e.RowIndex >= 0 && e.ColumnIndex == vehiclesTable.Columns["Verify"].Index)
            {
                // Retrieve the owner_id from the current row
                string owner_id = vehiclesTable.Rows[e.RowIndex].Cells["Owner_ID"].Value.ToString();

                // You can now use the owner_id for verification or any other logic
                //string update_verification_query = @"UPDATE vehicles SET verified='Verified' WHERE owner_id = " + owner_id;

                var result = MessageBox.Show(
                    "Are you sure you want to verify this user?",
                    "Confirm Verification",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Check if the user clicked "Yes"
                if (result == DialogResult.Yes)
                {
                    // Open a new connection for the verification update
                    using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                    {
                        conn.Open();
                        string update_verification_query = @"UPDATE vehicles SET verified='Verified' WHERE owner_id = @owner_id";
                        MySqlCommand cmd = new MySqlCommand(update_verification_query, conn);

                        // Use parameterized queries to prevent SQL injection
                        cmd.Parameters.AddWithValue("@owner_id", owner_id);
                        cmd.ExecuteNonQuery();
                    }

                    // Reload the table to reflect the updated data
                    vehiclesTable.Rows.Clear();
                    loadVehicles();
                }

                

            }
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

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide(); // Hide the login form
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        public void loadVehicles()
        {
            string queryVehicles = @"SELECT v.plate_number, v.owner_id, v.color, v.type, v.verified, COALESCE(e.first_name, s.first_name) AS first_name, COALESCE(e.last_name, s.last_name) AS last_name FROM vehicles v LEFT JOIN employees e ON v.owner_id = e.employee_number LEFT JOIN students s ON v.owner_id = s.student_number;";

            MySqlCommand cmd = new MySqlCommand(queryVehicles, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String first_name = reader["first_name"].ToString();
                String last_name = reader["last_name"].ToString();
                String color = reader["color"].ToString();
                String type = reader["type"].ToString();
                String plate_number = reader["plate_number"].ToString();
                String verified = reader["verified"].ToString();
                String owner_id = reader["owner_id"].ToString();


                vehiclesTable.Rows.Add(
                    first_name + last_name,
                    owner_id,
                    type,
                    plate_number,
                    color,
                    verified,
                    "Verify"
                );
            }
            reader.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panel_verified.Visible == true)
            {
                panel_verified.Visible = false;
            } else
            {
                panel_verified.BringToFront();
                panel_verified.Visible = true;
                panel_verified.Location = new Point(105, 105);
                loadVehicles();
            }
            
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            parkingPanel.Controls.Clear();
            parkingPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            PatioTrinidad parking_area1 = new PatioTrinidad();
            addUserControl(parking_area1);
            parking_area1.update_slot_buttons();
        }

        private void btnParking2_Click(object sender, EventArgs e)
        {
            CanteenSide canteen = new CanteenSide();
            addUserControl(canteen);
            canteen.update_slot_buttons();
        }

        private void btnMotorParking1_Click(object sender, EventArgs e)
        {
            GymSideMotor parking_motorcycle_area1 = new GymSideMotor();
            addUserControl(parking_motorcycle_area1);
            parking_motorcycle_area1.update_slot_buttons();

        }




        private void parking1_load_slot_buttons()
        {
            
        }

        

        

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            //if (admit_panel.Visible == false)
            //{
            //    admit_panel.Visible = true;
            //    admit_panel.Location = new Point(673, 209);
            //    admit_panel.BringToFront();
            //    load_queued_drivers();

            //}
            //else
            //{
            //    admit_panel.Visible = false;
            //}

            AdmitUser admitUser = new AdmitUser();
            admitUser.Show();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitUser exitUser = new ExitUser();
            exitUser.Show();
        }

        private void btnMotorParking2_Click(object sender, EventArgs e)
        {
            GymSide gymSide = new GymSide();
            addUserControl(gymSide);
            gymSide.update_slot_buttons();
        }

        private void SSCFront_Click(object sender, EventArgs e)
        {
            //GymSideMotor parking_motorcycle_area1 = new GymSideMotor();
            SSCFront sscfront = new SSCFront();
            addUserControl(sscfront);
            sscfront.update_slot_buttons();
        }

        private void btnPaymentsOffice_Click(object sender, EventArgs e)
        {
            PaymentsOffice paymentsOffice = new PaymentsOffice();
            addUserControl(paymentsOffice);
            paymentsOffice.update_slot_buttons();
        }

        private void btnRoadParking_Click(object sender, EventArgs e)
        {
            RoadParking roadparking = new RoadParking();
            addUserControl(roadparking);
            roadparking.update_slot_buttons();
        }

        private void btnPoolSide_Click(object sender, EventArgs e)
        {
            PoolSide poolSide = new PoolSide();
            addUserControl(poolSide);
            poolSide.update_slot_buttons();
        }
    }
}
