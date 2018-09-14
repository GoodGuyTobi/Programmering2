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
    public partial class CreateNewApartment : Form
    {
        // lokala variabler som alla metoder ska kunna komma åt och ändra på
        int apartmentNumber = 1001; // lägenhetsnummren börjar från 1001
        int roomsLeft = 10; // eftersom lägenhets huset innehåller en 1:a, 2:a, 3:a och 4:a finns det bara 10 rum kvar

        // variabler som ska ändras i denna form men som Form1 ska komma åt
        public int an = 4; // (apartmentnumber = an)
        public int rn = 10; // (roomnumber = rn)

        // variabler för att sparas i listor
        string numberOfRooms;   
        int numberOfRoomsInt;
        string availability;

        public List<string> apartmentName = new List<string>(); // en lista som håller namnen på lägenheterna
        public List<string> apartmentDetails = new List<string>();  // en lista som håller informationen om lägenheterna

        // det som startas varje gång denna form öppnas
        public CreateNewApartment()
        {
            InitializeComponent();
            Init(); // metod som håller andra metoder
        }

        // metod för att hålla andra metoder
        void Init()
        {
            FinishedApartments(); // först kallas de lägenheterna som finns från start
            GenerateApartmentNumber(); // sen genereras ett nummer till varje lägenhet
        }

        // metod för att spara värdena i egen index istället för att ändra värdet på index 4
        public List<string> GetAptList()
        {
            return apartmentName;
        }

        // metod för att spara värdena i egen index istället för att ändra värdet på index 4
        public List<string> GetDetList()
        {
            return apartmentDetails;
        }

        // metod som hanterar tillbakaknappen
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // gör den här formen "osynlig" (hide/gömmer)
        }

        // metod som hanterar sparaknappen
        private void btnSave_Click(object sender, EventArgs e)
        {
            // först kollar metoden vilket index användaren valt i antalet rum, index sparas som en sträng
            // sedan körs en TryParse på denna sträng för att omvandla värdet till en integer, eftersom 
            // datorn börjar räkna från 0 lägger vi till "1" till värdet
            numberOfRooms = lbxRooms.SelectedIndex.ToString();
            bool result = int.TryParse(numberOfRooms, out numberOfRoomsInt);
            numberOfRoomsInt += 1;

            // här kollar metoden så att antalet rum man valt inte gör att det totala överstiger 20
            // plus att den kollar så att man valt något på både antalet rum och om den är vakant eller ej
            // en bonus är att den kollar ifall TryParsen fungerade vilket den kommer att, men det är ett extra
            // steg för att se till att applikationen inte krashar
            if (roomsLeft > numberOfRoomsInt && lbxRooms.SelectedIndex >= 0 && lbxAvailability.SelectedIndex >= 0 && result)
            {
                // här kallas metoden som genererar lägenhetsnummer för att se till att nummret ökar med 1 varje gång 
                // man har lagt till en lägenhet, annars får alla samma lägenhetsnummer
                GenerateApartmentNumber();

                // antalen rum användaren valt sparas som sträng, eftersom vi vill ha värdet med +=1  och inte valt 
                // index väljer vi att ta värdet från integern och göra det till en string
                numberOfRooms = numberOfRoomsInt.ToString();
                // metoden som ändrar räknaren för antalet rum kallas och tar med sig antalet rum valda
                UpdateCounter(numberOfRoomsInt);

                // metod för att se om den nuvarande lägenheten är vakant eller ej och sedan spara det till listan
                VacantOrNot();

                // metod som tar alla värden och sparar ner i två listor
                ListTexts();

                // lägenhetsnumren ökar med ett och roomcountern öker med antalet rum valda
                apartmentNumber++;
                an++;
                rn += numberOfRoomsInt;

                // till sist göms fönstret undan
                this.Hide();
            }
                // om if-satsen inte gick igenom skickas ett felmeddelande som berättar det för användaren, sedan händer inget
                else { an--; MessageBox.Show("Please make sure you have filled in the options correctly and that there are enough rooms.",
                    "Oops something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        // metod för att uppdatera ettiketen som säger hur många rum som finns kvar, den tar in en integer eftersom
        // den måste få reda på hur många rum som lagts till och sedan göra en matematisk uträkning på det
        void UpdateCounter(int roomsFromRecentApartment)
        {
            // tillgängliga rum minskar med samma värde som användaren använde till sin senaste gjorda
            roomsLeft -= roomsFromRecentApartment; 
            // ettiketen uppdateras
            lblRoomCounter.Text = $"Number of rooms available: " + roomsLeft;
        }

        // metod för att kolla om lägenheten är vakant eller ej
        void VacantOrNot()
        {
            // här kollas vilket alternativ användaren valt 0 eller 1
            availability = lbxAvailability.SelectedIndex.ToString();

            // då vacant står överst har den position 0, då får availability värdet vacant
            if(availability == "0")
            {
                availability = "vacant";
            }
            // då occupied står nederst har den positionen 1, då får availability värdet occupied
            else
            {
                availability = "occupied";
            }
        }

        // metod som genererar lägenhetsnummer
        void GenerateApartmentNumber()
        {
            // texten i textboxen motsvarar lägenhetsnummret, då variabeln är en integer väljer
            // vi att omvandla den till en sträng (.ToString)
            tbxApartmentNumber.Text = apartmentNumber.ToString();
        }

        // metod som sparar ner en sträng till varje liste som ser olika ut beroende på värdet av variablerna
        void ListTexts()
        {
            apartmentName.Add($"Apartment {apartmentNumber.ToString()}");
            apartmentDetails.Add($"This apartment has {numberOfRooms} room(s) plus a kitchen.\n" +
                  $"This apartment is {availability}.");
        }

        // metod för att lägga till de lägenheterna som skulle finnas från början
        void FinishedApartments()
        {
            // istället för att skriva samma text 4 gånger körs en for-loop
            // då lägenhetsnummret börjar på 1 och inte 0 har jag ändrat så [i] börjar från 1
            // alla lägenheter blir occupied för enkelhetens skull
            for (int i = 1; i < 5; i++)
            {
                apartmentName.Add($"Apartment " + apartmentNumber);
                apartmentDetails.Add($"This apartment has " + i + " room(s) plus a kitchen.\n" +
                    "This apartment is occupied.");
                apartmentNumber++;
            }
        }

    }
}
