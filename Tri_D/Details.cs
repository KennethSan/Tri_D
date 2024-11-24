using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tri_D.History;

namespace Tri_D
{
    public partial class Details : UserControl
    {
        public Details()
        {
            InitializeComponent();
        }


        private void Details_Load(object sender, EventArgs e)
        {
            nameDetails.Text = OwnerDetails.OwnerName;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
