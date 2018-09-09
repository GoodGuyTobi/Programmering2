using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentBuilder
{
    public partial class ApartmentBuilder : Form
    {
        public ApartmentBuilder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApartmentBuilder_Load(object sender, EventArgs e)
        {

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            Form1 menu;
            menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
