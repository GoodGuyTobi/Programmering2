using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonForms
{
    public partial class Form1 : Form
    {
        List<Farmer> farmers = new List<Farmer>();

        //Constructor
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            AddFarmers();
            UpdateCombobox();
        }

        void AddFarmers()
        {
            farmers.Add(new Farmer("Stefan"));
            farmers.Add(new Farmer("Klas"));
        }

        void UpdateCombobox()
        {
            foreach (Farmer farmer in farmers)
            {
                cbxFarmers.Items.Add(farmer.Name);
            }

            cbxFarmers.SelectedIndex = 0;
        }

        void UpdateListBox()
        {
            lbxAnimals.Items.Clear();
            List<string> animals;
            int index = cbxFarmers.SelectedIndex;

            animals = farmers[index].GetAnimalInfo();

            if (animals.Count > 0)
            {
                foreach (string animal in animals)
                {
                    lbxAnimals.Items.Add(animal);
                }
            }
        }


        // Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string species = txtSpecies.Text;
            int legs;
            bool result = int.TryParse(txtLegs.Text, out legs);


            if (species != "" && result)
            {
                int index = cbxFarmers.SelectedIndex;

                farmers[index].AddAnimal(species, legs);

                UpdateListBox();
            }


        }

        private void cbxFarmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
