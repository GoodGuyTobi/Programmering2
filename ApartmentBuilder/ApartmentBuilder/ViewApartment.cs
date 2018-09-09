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
    public partial class ViewApartment : Form
    {
        public ViewApartment()
        {
            InitializeComponent();
        }

        private void viewOwn_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 menu;
            menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void ViewApartment_Load(object sender, EventArgs e)
        {

        }
    }
}
