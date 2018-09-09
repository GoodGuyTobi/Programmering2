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
    public partial class Form1 : Form
    {
        ApartmentBuilder aptBuilder;
        ViewApartment aptViewer;
        public Form1()
        {
            InitializeComponent();
            aptBuilder = new ApartmentBuilder();
            aptViewer = new ViewApartment();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crtApt_Click(object sender, EventArgs e)
        {
            aptBuilder.Show();
            this.Close();
        }

        private void viewApt_Click(object sender, EventArgs e)
        {
            aptViewer.Show();
            this.Close();
        }
    }
}
