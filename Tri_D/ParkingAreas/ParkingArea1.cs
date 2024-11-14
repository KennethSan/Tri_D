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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tri_D.ParkingAreas
{
    public partial class ParkingArea1 : UserControl
    {
        MySqlConnection connection = connectionDB.GetConnection();
        public ParkingArea1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       public void update_slot_buttons()
       {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query_get_slots = @"SELECT * FROM parkingslot";
                MySqlCommand cmd = new MySqlCommand(query_get_slots, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string slot_number = reader["slot_number"].ToString();
                    string status = reader["status"].ToString();

                    // Find button directly in the UserControl's Controls collection
                    Guna.UI2.WinForms.Guna2Button slotButton = this.Controls.Find("btnSlot" + slot_number, true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;
                    
                    if (slotButton != null)
                    {
                        
                        if (status.ToLower() == "occupied")
                        {
                            slotButton.BackgroundImage = Properties.Resources.g
                        }
                        //slotButton.FillColor = status.ToLower() == "occupied" ? Color.Red : Color.Green;
                    }
                }
                reader.Close();
            }
       }

    }
}
