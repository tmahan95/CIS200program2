/* Grading ID: D2575
 * Due 11/1/16
 * Section: 76
 * Description: This is the main form of Program 2. It stores the UPV object as well as a menu and a text box.
 * the menu contains options for closing the application, opening the About information of the program, as well as options
 * for creating addresses and letters, as well as options for showing all addresses and parcels.
 * This for pulls data from the child forms that are used to create Addresses and letters. It listens for their
 * Dialog Resuslts to be OK, and once this occurs, the data is pulled and the objects are created and added to the
 * UPV object's list.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        //Field
        private UserParcelView _upvTest = new UserParcelView(); //Object that contains all test data and new data as program runs

        //Constructor
        //precondition: must have UPV object to store test data
        //postcondition: main form GUI is initialized
        public Prog2Form()
        {
            //Test Data: Addresses
            _upvTest.AddAddress("John Smith", "123 Any St.", "Apt. 45",
               "Louisville", "KY", 40202); // Test Address 1
            _upvTest.AddAddress("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            _upvTest.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            _upvTest.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            _upvTest.AddAddress("James Haverstock", "10101 Linn Station Rd", "Suite 200",
                "Louisville", "KY", 40223); // Test Address 5
            _upvTest.AddAddress("Paul Jacob", "4107 SpyGlass Ct", "",
                "Louisville", "KY", 40229); // Test Address 6
            _upvTest.AddAddress("Laura Payne", "320 E Esplenade Ave", "",
                "Louisville", "KY", 40213); // Test Address 7
            _upvTest.AddAddress("Geraldine Spicer", "8601 Timberhallow Ct", "",
                "Louisville", "KY", 40219); // Test Address 8

            //Test Date: Parcels
            _upvTest.AddLetter(_upvTest.AddressAt(0),_upvTest.AddressAt(2), 1.50M); // Test Letter 1
            _upvTest.AddLetter(_upvTest.AddressAt(2), _upvTest.AddressAt(4), 1.25M); // Test Letter 2
            _upvTest.AddLetter(_upvTest.AddressAt(4), _upvTest.AddressAt(0), 1.75M); // Test Letter 3
            _upvTest.AddGroundPackage(_upvTest.AddressAt(5),_upvTest.AddressAt(6),3,6,9,12); // Test GroundPackage 1
            _upvTest.AddGroundPackage(_upvTest.AddressAt(4),_upvTest.AddressAt(7),12,9,6,3); // Test GroundPackage 2
            _upvTest.AddGroundPackage(_upvTest.AddressAt(3), _upvTest.AddressAt(7), 6,7,9,100); // Test GroundPackage 3
            _upvTest.AddNextDayAirPackage(_upvTest.AddressAt(4), _upvTest.AddressAt(7), 500,12,12,12,12); // Test NextDayAirPackage 1
            _upvTest.AddNextDayAirPackage(_upvTest.AddressAt(7), _upvTest.AddressAt(2), 20, 7, 7, 7, 70) ; // Test NextDayAirPackage 2
            _upvTest.AddNextDayAirPackage(_upvTest.AddressAt(1), _upvTest.AddressAt(4), 5, 1, 2, 3, 4); // Test NextDayAirPackage 3
            _upvTest.AddTwoDayAirPackage(_upvTest.AddressAt(3), _upvTest.AddressAt(6), 9, 9, 9, 200, TwoDayAirPackage.Delivery.Saver); //Test TwoDayAirPackage 1
            _upvTest.AddTwoDayAirPackage(_upvTest.AddressAt(6), _upvTest.AddressAt(1), 10, 20, 30, 40, TwoDayAirPackage.Delivery.Early); //Test TwoDayAirPackage 2
            _upvTest.AddTwoDayAirPackage(_upvTest.AddressAt(1), _upvTest.AddressAt(6), 100, 90, 80, 76, TwoDayAirPackage.Delivery.Saver); //Test TwoDayAirPackage 3
            
            InitializeComponent();
        }

        //Properties
        //precondition: none
        //postcondition: returns the value of the _upvTest field.
        internal UserParcelView UpvTest
        {
            //precondition: none
            //postcondition:  returns the value of the _upvTest field.
            get { return _upvTest; }
        }

        //Menu Items and such
        //precondition: none
        //postcondition: MessageBox that displays my name, prog#, due date, and section
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timmy Mahan\nProgram2\nDue: 11/1/14\nSection: 76");
        }

        //precondition: none
        //postcondition: Application exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //precondition: upv object must exist
        //postcondition: creates a dialog box, if valid data is entered, an Address is added to the UPV
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressDialog childForm = new AddressDialog();
            DialogResult result; // stores result from dialog
            string name = "Test"; // stores value of childForm Name property
            string address1 = "TEST1"; // stores value of childForm Address1 property
            string address2 = "Test2"; // stores value of childForm Address2 property
            string city = "Test3"; // stores value of childForm City property
            string state = "KY"; // stores value of childForm State property
            int zip = -1; // stores value of childForm Zip property

            result = childForm.ShowDialog();

            if (result == DialogResult.OK) //add address if childForm Dialog result is OK
            {
                name = childForm.Person; //these pull data from the childForm
                address1 = childForm.Address1;
                address2 = childForm.Address2;
                city = childForm.City;
                state = childForm.State;
                int.TryParse(childForm.Zip, out zip);

                _upvTest.AddAddress(name, address1, address2, city, state, zip); //here the address is actually added to upv object
            }
        }

        //precondition: upv object must exist
        //postcondition: creates a dialog box, if data entered is valid, 
        // a new letter object is added to the upv object
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterDialog letterForm = new LetterDialog(UpvTest.AddressList);
            DialogResult result; // stores DialogResult OK/Cancel
            Address originAddr; // stores letterFrom OriginAddr property
            Address destAddr; // stores letterForm DestAddr property
            decimal fixedCost; // stores letterForm FixedCost property

            result = letterForm.ShowDialog(); // creates letterForm dialog

            if (result == DialogResult.OK) //add letter object to upv if DialogResult is OK
            {
                originAddr = letterForm.OriginAddress; //here is where property values are actually stored on the main form
                destAddr = letterForm.DestAddress;
                decimal.TryParse(letterForm.FixedCost, out fixedCost);

                _upvTest.AddLetter(originAddr, destAddr, fixedCost); // actually adds the letter object to the form
            }
        }

        //precondition: upv object must exist
        //postcondition: the upv object list of address has been written to the textbox as a string
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptTxtBox.Clear(); //get rid of any previously existing text
            StringBuilder result = new StringBuilder(); // new stringbuilder to efficiently create a string of our upv address data
            string N = Environment.NewLine; //Shorthand for NewLine
            foreach (Address s in _upvTest.AddressList)
            {
                result.Append(s.ToString() + N + N);
            }
            rptTxtBox.Text = result.ToString();// sends stringbuilder result to our textbox object

        }

        //precondition: upv object must exist
        //postcondition: the upv object list of letters has been written the textbox as a string
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptTxtBox.Clear(); // get rid of any previously existing text
            StringBuilder result = new StringBuilder(); // new stringbuilder to efficiently create a string of our upv letter data
            string N = Environment.NewLine; //Shorthand for NewLine
            foreach (Parcel s in _upvTest.ParcelList)
            {
                result.Append(s.ToString() + N + N);
            }
            rptTxtBox.Text = result.ToString(); //sends stringbuilder result to our textbox object
        }
    }
}
