using Guna.UI2.WinForms;
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
using static Tri_D.History;

namespace Tri_D
{
    public partial class DetailsUser : Form
    {
        public DetailsUser()
        {
            InitializeComponent();
            nameDetails.Text = OwnerDetails.OwnerName;
            typeDetails.Text = OwnerDetails.OwnerType;
            string queryHistory = "";
            string queryCars = @"SELECT * FROM vehicles WHERE owner_id=" + OwnerDetails.OwnerID;

            MySqlConnection connection = connectionDB.GetConnection();
            
            if (OwnerDetails.OwnerType == "Employee")
            {
                queryHistory = @"SELECT * FROM employees WHERE employee_number=" + OwnerDetails.OwnerID;
            } else if (OwnerDetails.OwnerType == "Student")
            {
                queryHistory = @"SELECT * FROM students WHERE student_number=" + OwnerDetails.OwnerID;
            } else if (OwnerDetails.OwnerType == "Guest")
            {
                queryHistory = @"SELECT * FROM guests WHERE guest_number=" + OwnerDetails.OwnerID;
            }

            using (MySqlCommand cmd = new MySqlCommand(queryHistory, connection))
            {
                //cmd.Parameters.AddWithValue("@OwnerID", ownerID.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string email = reader["email"].ToString();
                    string telephone = reader["telephone"].ToString();
                    string address = reader["address"].ToString();
                    string qr_id = "";

                    if (OwnerDetails.OwnerType == "Employee")
                    {
                        qr_id = reader["employee_id_image"].ToString();
                    }
                    else if (OwnerDetails.OwnerType == "Student")
                    {
                        qr_id = reader["student_id_image"].ToString();

                    }
                    else if (OwnerDetails.OwnerType == "Guest")
                    {
                        qr_id = reader["id_image"].ToString();

                    }

                    addressDetails.Text = address;
                    lblEmail.Text = email;
                    lblTelephone.Text = telephone;

                    DisplayImageFromBase64(qr_id, pictureDetail);
                }

                reader.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(queryCars, connection))
            {

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string plate_number = reader["plate_number"].ToString();
                    string brand = reader["brand"].ToString();
                    string type = reader["type"].ToString();
                    string verified = reader["verified"].ToString();

                    vehicleTable.Rows.Add(plate_number, brand, type, verified);
                    
                }

                reader.Close();
            }
        }

        private void DisplayImageFromBase64(string base64String, PictureBox pictureBox)
        {
            try
            {
                // Remove any whitespace characters from the base64 string
                base64String = base64String.Trim();

                // Ensure the base64 string has a length that is a multiple of 4
                int paddingLength = base64String.Length % 4;
                if (paddingLength > 0)
                {
                    base64String = base64String.PadRight(base64String.Length + (4 - paddingLength), '=');
                }

                // Convert the base64 string to a byte array
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Create an Image object from the byte array and display it in the PictureBox
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void pictureDetail_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
