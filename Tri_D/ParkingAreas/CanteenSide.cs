using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tri_D.ParkingAreas
{
    public partial class CanteenSide : UserControl
    {
        MySqlConnection connection = connectionDB.GetConnection();
        public CanteenSide()
        {
            InitializeComponent();
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
                    Guna.UI2.WinForms.Guna2Button slotButtonU = this.Controls.Find("btnSlotU_" + slot_number, true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;
                    Guna.UI2.WinForms.Guna2Button slotButtonD = this.Controls.Find("btnSlotD_" + slot_number, true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;
                    Guna.UI2.WinForms.Guna2Button slotButtonL = this.Controls.Find("btnSlotL_" + slot_number, true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;
                    Guna.UI2.WinForms.Guna2Button slotButtonR = this.Controls.Find("btnSlotR_" + slot_number, true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;


                    if (slotButtonU != null)
                    {

                        if (status.ToLower() == "occupied")
                        {
                            slotButtonU.Image = Image.FromStream(new MemoryStream(Properties.Resources.CAR_U));
                            slotButtonU.PressedColor = Color.Red;
                            slotButtonU.ImageSize = new Size(120, 120);

                        }
                        else
                        {
                            slotButtonU.Image = Image.FromStream(new MemoryStream(Properties.Resources.GREENCIRCLE));
                            slotButtonU.PressedColor = Color.Green;
                            slotButtonU.ImageSize = new Size(20, 20);

                        }
                    }

                    if (slotButtonD != null)
                    {

                        if (status.ToLower() == "occupied")
                        {
                            slotButtonD.Image = Image.FromStream(new MemoryStream(Properties.Resources.CAR_D));
                            slotButtonD.PressedColor = Color.Red;
                            slotButtonD.ImageSize = new Size(120, 120);

                        }
                        else
                        {
                            slotButtonD.Image = Image.FromStream(new MemoryStream(Properties.Resources.GREENCIRCLE));
                            slotButtonD.PressedColor = Color.Green;
                            slotButtonD.ImageSize = new Size(20, 20);

                        }
                    }

                    if (slotButtonR != null)
                    {

                        if (status.ToLower() == "occupied")
                        {
                            slotButtonR.Image = Image.FromStream(new MemoryStream(Properties.Resources.CAR_R));
                            slotButtonR.PressedColor = Color.Red;
                            slotButtonR.ImageSize = new Size(120, 120);
                        }
                        else
                        {
                            slotButtonR.Image = Image.FromStream(new MemoryStream(Properties.Resources.GREENCIRCLE));
                            slotButtonR.PressedColor = Color.Green;
                            slotButtonR.ImageSize = new Size(20, 20);
                        }
                    }

                    if (slotButtonL != null)
                    {

                        if (status.ToLower() == "occupied")
                        {
                            slotButtonL.Image = Image.FromStream(new MemoryStream(Properties.Resources.CAR_L));
                            slotButtonL.PressedColor = Color.Red;
                            slotButtonL.ImageSize = new Size(120, 120);

                        }
                        else
                        {
                            slotButtonL.Image = Image.FromStream(new MemoryStream(Properties.Resources.GREENCIRCLE));
                            slotButtonL.PressedColor = Color.Green;
                            slotButtonL.ImageSize = new Size(20, 20);

                        }
                    }

                }
                reader.Close();
            }
        }

        private void btnSlot_Click(object sender, EventArgs e)
        {
            // Get the button that was clicked
            Guna.UI2.WinForms.Guna2Button clickedButton = (Guna.UI2.WinForms.Guna2Button)sender;

            // Extract slot number from button name (e.g., "btnSlotU_A1" -> "A1")
            string slotNumber = clickedButton.Name.Split('_')[1];

            if (clickedButton.PressedColor == Color.Red)
            {
                ViewUserDetailsManage viewUserDetailsManage = new ViewUserDetailsManage(slotNumber);
                viewUserDetailsManage.Show();
            }


        }
    }
}
