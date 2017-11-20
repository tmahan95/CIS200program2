/* Grading ID: D2575
 * Due 11/1/16
 * Section: 76
 * Description: this form accepts data for the name, address1, address2, city, state, and zip of an address, and passes
 * that data to the main form when the Dialog Result is OK. If the Dialog Result is Cancel, no data is passed
 * to the main form.
 * This form also does the data validation required to create an address object. If the data is not successfully
 * validated, the data from the form is not submitted.
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
    public partial class AddressDialog : Form
    {
        private const int MIN_ZIP = 0; // minimum zip code value
        private const int MAX_ZIP = 99999; // max zip code value

        //Constructor
        //precondition: none
        //postcondition: a new address form will be created
        public AddressDialog()
        {
            InitializeComponent();
        }

        //precondition: none
        //postcondition: returns the Person property of the form
        internal string Person
        {
            //precondition: none 
            //postcondition:  returns the Person property of the form
            get { return nameTxtBox.Text; }
        }

        //precondition: none
        //postcondition: returns the Address1 property of the form
        internal string Address1
        {
            //precondition:none
            //postcondition: returns the Address1 property of the form
            get { return addr1TxtBox.Text; }
        }

        //precondition: none
        //postcondition: returns the Address2 property of the form
        internal string Address2
        {
            //precondition: none
            //postcondition: returns the Address2 property of the form
            get { return addr2TxtBox.Text; }
        }

        //precondition:none
        //postcondition: returns the City property of the form
        internal string City
        {
            //precondition: none
            //postcondition: returns the City property of the form
            get { return cityTxtBox.Text; }
        }

        //precondition: none
        //postcondition: returns the State property of the form
        internal string State
        {
            //precondition: none
            //postcondition: returns the State property of the form
            get { return stateComBox.SelectedItem.ToString(); }
        }

        //precondition: none
        //postcondition: returns the Zip property of the form
        internal string Zip
        {
            //precondition:none
            //postcondition: returns the Zip property of the form
            get { return zipTxtBox.Text; }
        }

        //precondition: user creates new Address Form
        //postcondition: Data is loaded into the State combo box
        private void AddressDialog_Load(object sender, EventArgs e)
        {
            stateComBox.Items.Add("KY");
            stateComBox.Items.Add("IN");
            stateComBox.Items.Add("TN");
            stateComBox.Items.Add("OH");
        }

        //precondition: attempt to change focus from the name input
        //postcondition: allows focus to change if data entered is a non-empty string, else focus does not change and errorprovider shows and error
        private void nameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string test = nameTxtBox.Text; //temporary string variable to hold name input
            if (test == null)
            {
                e.Cancel = true; //stops focus change
                errorProvider1.SetError(nameTxtBox, "Enter a name in the Name text box!");
            }
            else if (test == "")
            {
                e.Cancel = true; //stops focus change
                errorProvider1.SetError(nameTxtBox, "Enter a name in the Name text box!");
            }

        }

        //precondition: name input validation succeeded
        //postcondition: error messages are cleared, focus is allowed to change
        private void nameTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTxtBox, "");
        }

        //precondition: attempt to change focus from address1 input
        //postcondition: if input is a non-empty string, focus is allowed to change, else the focus remains on Address1 input and errorprovider shows an error
        private void addr1TxtBox_Validating(object sender, CancelEventArgs e)
        {
            string test = addr1TxtBox.Text; //temporary string variable to hold the address1 input
            if (test == null)
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(addr1TxtBox, "Enter a name in the Name text box!");
            }
            else if (test == "")
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(addr1TxtBox, "Enter a name in the Name text box!");
            }
        }

        //precondition: validation of addr1TxtBox succeeded
        //postcondition: clears error messages, focus is allowed to change
        private void addr1TxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addr1TxtBox, "");
        }

        //precondition: user tries to change focus from city input
        //postcondition: if input is a non-empty string, the focus will be allowed to change, else an error message is shown and focus change is cancelled.
        private void cityTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string test = cityTxtBox.Text; //temporary string variable to hold the city input
            if (test == null)
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(cityTxtBox, "Enter a city in the City box!");
            }
            else if (test == "")
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(cityTxtBox, "Enter a city in the City box!");
            }

        }

        //precondition: validation of cityTxtBox succeeded
        //postcondition: clears error messages, focus is allowed to change
        private void cityTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTxtBox, "");
        }

        //precondition: user tries to change focus from the state combo box
        //postcondition: if the input is an item selected from the combo box, the focus is allowed to change, else an error is thrown telling the user to pick a state
        private void stateComBox_Validating(object sender, CancelEventArgs e)
        {
            if (stateComBox.SelectedIndex == -1)
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(stateComBox, "Pick a state!");
            }
        }

        //precondition: validation of stateComBox succeeded
        //postcondition: clears error messages, focus is allowed to change
        private void stateComBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateComBox, "");
        }

        //precondition: user tries to change focus from the zip input
        //postcondition: if the value entered successfully parses, is no greater than the max zip and no less than the min xip, focus is allowed to change
                      // else the focus change is canceled and an error message is shown.
        private void zipTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(zipTxtBox.Text, out num)) //temporary int variable to hold the zip input
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(zipTxtBox, "Enter an integer!");
            }
            else if (num < MIN_ZIP)
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(zipTxtBox, "Enter a non-negative integer!");
            }
            else if (num > MAX_ZIP)
            {
                e.Cancel = true;//stops focus change
                errorProvider1.SetError(zipTxtBox, "Zipcode cannot be longer than 5 digits!");
                zipTxtBox.SelectAll(); //Help show where user goofed.
            }
                             
        }

        //precondition: validation of zipTxtBox succeeded
        //postcondition: clears error messages, focus is allowed to change
        private void zipTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTxtBox, "");
        }

        //precondition: user clicks the OK (createAddrBttn) button
        //postcondition: if all inputs are validated, the dialog result is changed to OK and data is submitted to main form.
        private void createAddrBttn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            { this.DialogResult = DialogResult.OK; }
        }

        //precondition: user clicks the Cancel button
        //postcondition: Dialog result is set to cancel, the Address form closes and no data is submitted to the main form.
        private void cnclBttn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}