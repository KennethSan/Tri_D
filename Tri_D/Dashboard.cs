using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tri_D
{
    public partial class Dashboard : Form
    {
        bool sidebarExpand;
        MySqlConnection connection = connectionDB.GetConnection();
        public Dashboard()
        {
            InitializeComponent();

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

            sidebar.Width = sidebar.MinimumSize.Width;
            refreshLoad.Start();
            RefreshParkingCounts();
            /*MySqlConnection connection = connectionDB.GetConnection();
            string queryVacant = "SELECT COUNT(*) AS vacant_count FROM parkingslot WHERE status = 'vacant';";
            string queryOccupied = "SELECT COUNT(*) AS occupied_count FROM parkingslot WHERE status = 'occupied';";
            string queryTotalslot = "SELECT COUNT(*) AS total_slots FROM parkingslot;";

            MySqlCommand commandSql = new MySqlCommand(queryVacant, connection);
            MySqlCommand commandSql2 = new MySqlCommand(queryOccupied, connection);
            MySqlCommand commandSql3 = new MySqlCommand(queryTotalslot, connection);

            int vacantCar = Convert.ToInt32(commandSql.ExecuteScalar()); 
            int occupiedCar = Convert.ToInt32(commandSql2.ExecuteScalar());
            int maximumSlot = Convert.ToInt32(commandSql3.ExecuteScalar());
            vacantnumLabel.Text = vacantCar.ToString();
            occupiednumLabel.Text = occupiedCar.ToString();
            carAvailabilityProgress.Value = occupiedCar;
            carAvailabilityProgress.Maximum = maximumSlot;*/

        }
        private void RefreshParkingCounts()
        {
            
            string queryVacant = "SELECT COUNT(*) AS vacant_count FROM parkingslot WHERE status = 'vacant';";
            string queryOccupied = "SELECT COUNT(*) AS occupied_count FROM parkingslot WHERE status = 'occupied';";
            string queryTotalslot = "SELECT COUNT(*) AS total_slots FROM parkingslot;";

            string queryVacantMotor = "SELECT COUNT(*) AS vacantMotor_count FROM parkingslotmotorcycle WHERE status = 'vacant';";
            string queryOccupiedMotor = "SELECT COUNT(*) AS occupiedMotor_count FROM parkingslotmotorcycle WHERE status = 'occupied';";
            string queryTotalslotMotor = "SELECT COUNT(*) AS totalMotor_slots FROM parkingslotmotorcycle;"; 
            string querybar = @"
        SELECT HOUR(time_in) AS hour, COUNT(*) AS count 
        FROM history 
        GROUP BY HOUR(time_in) 
        ORDER BY hour;";

            MySqlCommand commandSql = new MySqlCommand(queryVacant, connection);
            MySqlCommand commandSql2 = new MySqlCommand(queryOccupied, connection);
            MySqlCommand commandSql3 = new MySqlCommand(queryTotalslot, connection);
            MySqlCommand commandSql4 = new MySqlCommand(queryVacantMotor, connection);
            MySqlCommand commandSql5 = new MySqlCommand(queryOccupiedMotor, connection);
            MySqlCommand commandSql6 = new MySqlCommand(queryTotalslotMotor, connection);
            MySqlCommand commandszz = new MySqlCommand(querybar, connection);

            int vacantCar = Convert.ToInt32(commandSql.ExecuteScalar());
            int occupiedCar = Convert.ToInt32(commandSql2.ExecuteScalar());
            int maximumSlot = Convert.ToInt32(commandSql3.ExecuteScalar());

            int vacantMotor = Convert.ToInt32(commandSql4.ExecuteScalar());
            int occupiedMotor = Convert.ToInt32(commandSql5.ExecuteScalar());
            int maximumSlotMotor = Convert.ToInt32(commandSql6.ExecuteScalar());

            vacantnumLabel.Text = vacantCar.ToString();
            occupiednumLabel.Text = occupiedCar.ToString();
            carAvailabilityProgress.Value = occupiedCar;
            carAvailabilityProgress.Maximum = maximumSlot;

            vacantnumMOTORLabel.Text = vacantMotor.ToString();
            occupiednumMOTORLabel.Text = occupiedMotor.ToString();
            motorAvailabilityProgress.Value = occupiedMotor;
            motorAvailabilityProgress.Maximum = maximumSlotMotor;

            using (MySqlDataReader reader = commandszz.ExecuteReader())
            {
                // Clear the existing points in the series
                chart1.Series["MorningHrs"].Points.Clear();

                // Add points dynamically to the series
                while (reader.Read())
                {
                    int hour = reader.GetInt32("hour");  // Get the hour
                    int count = reader.GetInt32("count"); // Get the count for that hour

                    // Add point to the chart series
                   if (hour <= 11) { chart1.Series["MorningHrs"].Points.AddXY(hour, count); }
                   else {
                        int adjustedHour = hour - 12; // Subtract 12 to make 13 become 1, 14 become 2, etc.
                        if (adjustedHour == 0) { chart1.Series["EveningHrs"].Points.AddXY(adjustedHour+12, count); }
                        else { chart1.Series["EveningHrs"].Points.AddXY(adjustedHour, count); }
                        
                    }
                    

                }

            }
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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
                if(sidebar.Width == sidebar.MaximumSize.Width)
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

        private void manageButton_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void refreshLoad_Tick(object sender, EventArgs e)
        {
            RefreshParkingCounts();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
       

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
