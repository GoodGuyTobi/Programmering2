//Code by: Arvid "GoodGuyTobi" Tapper
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentBuilderV2
{
    public partial class Form1 : Form
    {

        // Då mängden kod inte blev allt för mycket har jag endast två klasser, en till varje Form
        // En förbättring hade givetvis varit att ha fler mindre klasser som hanterar en sak, till exempel
        // en klass som hanterar vad en lägenhet har för information etc..
        // Andra förbättringar hade varit om man kund elagt till namn på personerna som bodde i de upptagna lägenheterna
        // Det skulle också vara ett plus om det gick att radera vissa lägenheter
        // Det jag stört mig mest på är att listan och ettiketerna på Form1 inte uppdateras på en gång när man 
        // sparar en lägenhet och jag visste inte riktigt hur jag skulle fixa det, lösningarna jag hittade online
        // var för komplicerade för att jag skulle kunna förklara vad jag gjort så då valde jag istället
        // att inte inkludera de alls.



        // Här ser vi till att vi kan kalla på våran andra klass, CreateNewApartment
        CreateNewApartment createApartment = new CreateNewApartment();

        // Allt som händer när applikationen startas
        public Form1()
        {
            InitializeComponent();
            // Här kallas metoden för att hämta de lägenheter som finns med från början
            GetAptList();
        }

        // Metod för att lägga till lägenhetsnummret i listboxen
        public void GetAptList()
        {
            // list som får samma värde som listan som håller apartmentNumber i den andra klassen
            List<string> apartmentNames = createApartment.GetAptList();

            // for-loop som loopas antalet platser som finns i listan
            for (int i = 0; i < apartmentNames.Count; i++)
            {
                // Här skrivs listans item för positionen "i" ut i listboxen
                lbxApartments.Items.Add(apartmentNames[i]);
            }
        }

                // CLICK EVENTS

        // Knapp för att uppdatera etiketterna och listan men främst för att kalla på
        // den Form som skapar en ny lägenhet
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            // Ser till att texten i listboxen inte fördubblas när man klickar på CreateNew
            lbxApartments.Items.Clear();
            // Update-Events
            // Dessa två metoder uppdaterar etiketterna som säger hur många rum och lägenheter som finns
            apartmentsTaken();
            roomsTaken();
            // Den här metoden uppdaterar fönstret med lägenheterna
            GetAptList();

            // Check-Event
            // Denna metod kollar om lägenhetshuset har plats för ännu en lägenhet
            SpareApartments();
        }

        // Ungefär som CreateNew knappen, förutom att den här endast uppdaterar det aktuella fönstret
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update-Events
            // Rensar listan för att inte få text på text etc..
            lbxApartments.Items.Clear();
            // Dessa två metoder uppdaterar etiketterna som säger hur många rum och lägenheter som finns
            apartmentsTaken();
            roomsTaken();
            // Den här metoden uppdaterar fönstret med lägenheterna.
            GetAptList();
        }

        // Funktion för att ändra informationen om lägenheten baserad på vilken lägenhet som är vald
        private void lbxApartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Informationslistan nollställs för att inte få text på text
            tbxApartmentDetails.Text = "";

            // Den valda lägenhetens position sparas som en integer
            int index = lbxApartments.SelectedIndex;
            // En lista skapas och får värdet från listan som skapas när man sparar sina lägenheter i 
            // den andra Formen
            List<string> aptDetails = createApartment.GetDetList();

            // if-sats för att inte applikationen ska krasha om man klickar på tomt område
            if (index >= 0)
            {
                // Om man klickar på ett tillåtet område kommer rutan till höger fyllas med information
                // om just den lägenhets positionen man klickat på
                tbxApartmentDetails.Text = aptDetails[index];
            }
            else {
                // Om man klickade utanför de listade artiklarna kommer man få ett pop-up fönster
                // som säger att man gjort fel och inget mer händer
                MessageBox.Show("Please enter a valid field!", "Oops something went wrong...",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metod för att användaren ska se antalet lägenheter kvar
        void apartmentsTaken()
        {
            // Texten om hur många lägenheter användaren har skrivs ut och ändras varje gång en 
            // lägenhet läggs till
            lblApartmentCounter.Text = $"Apartments: {createApartment.an.ToString()}/7";
        }

        // Metod för att användaren ska se antalet rum kvar
        void roomsTaken()
        {
            // Texten om hur många rum användaren har skrivs ut och ändras varje gång 
            // rum läggs till
            lblRoomCounter.Text = $"Rooms: {createApartment.rn}/20";
        }

        // Ser till att man inte kan skapa ny lägenhet om lägenhetshuset är fullt
        void SpareApartments()
        {
            // Då man kan ha max 7 lägenheter kollar if-satsen om man har färre än 7
            if (createApartment.an < 7)
            {
                // Om man har färre än 7 kallas Formen som innehåller det som krävs för att skapa 
                // en ny lägenhet
                createApartment.Show();
            }
            else
            {
                // Om man redan har 7 lägenheter skickas ett felmeddelande ut till användaren
                MessageBox.Show("This building can only contain 7 apartments.", "Building full",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
