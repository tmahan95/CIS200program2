/* Grading ID: D2575
 * Due 11/1/16
 * Section: 76
 * Description: This form is used to accept inputs to create letter objects. It populates combo boxes that users 
 * can use to select the origin and destination addresses of the letter form, as well as enter the fixed cost of the
 * letter. When the Dialog result is OK, the letter form submits the data to the main form. When the Dialog Result is Cancel,
 * the form is closed and no data is submitted to the main form.
 * This form also does the validation for the data required to create a letter object.
 * If the data is not succesfully validated, the Dialog Result is not set to OK, and the data is no passed to the main form.
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
    public partial class LetterDialog : Form
    {
        //Fields
        private Address _originAddress; //stores originAddress property
        private Address _destAddress; //stores destAddress property
        private string _fixedCost; //stores fixed cost property
        List<Address> addresses = new List<Address>();

        //Constructor
        //precondition: none
        //postcondition: Letter form is created
        public LetterDialog(List<Address> AddressList)
        {
            addresses = AddressList;
            InitializeComponent();
        }

        //properties
        internal List<Address> Addresses
        {
            get { return addresses; }
        }
        //precondition: value must be an address
        //postcondition: gets or sets the value of the form's origin address
        internal Address OriginAddress
        {
            //precondition: none
            //postcondition: OriginAddress of the form has been returned
            get { return _originAddress; }
            //precondition: value must be an address
            //postcondition: the OriginAddress of the form has been set to the specified value
            set { _originAddress = value; }
        }

        //precondition: value must be an address
        //postcondition: gets or sets the DestAddress of the form
        internal Address DestAddress
        {
            //precondition: none 
            //postcondition: the DestAddress of the form has been returned
            get { return _destAddress; }
            //precondition: none
            //postcondition: the DestAddress of the form has been set
            set { _destAddress = value; }
        }

        //precondition: value must be a string
        //postcondition:  gets or sets the value of the fixedcost of the form
        internal string FixedCost
        {
            //precondition: none
            //postcondition: returns the fixed cost of the form
            get { return _fixedCost; }
            //precondition: none
            //postcondition: sets the fixed cost of the form
            set { _fixedCost = value; }
        }

        //events
        //precondition: Attempt to create letter form
        //postcondition: loads the letter dialog box with populated combo boxes for the origin and destination addresses
        private void LetterDialog_Load(object sender, EventArgs e)
        {
            foreach (Address x in addresses) //x is a temporary variable used to step through the address list
            {
                destAddrComBox.Items.Add(x);
                originAddrComBox.Items.Add(x);
            }
            originAddrComBox.DisplayMember = "Name"; //only display the name of each address in the combo box
            destAddrComBox.DisplayMember = "Name"; //only display the name of each address in the combo box
        }

        //precondition: attempt to change focus from fixed cost box
        //postcondition: If the value entered is a valid decimal, the focus will change. Otherwise, the errorprovider will show an error next to the control
        private void fixedCostTxtBox_Validating(object sender, CancelEventArgs e)
        {
            decimal num; // temporary variable to hold fixed cost of form
            if (!decimal.TryParse(fixedCostTxtBox.Text, out num))
            {
                e.Cancel = true; //don't allow focus to change
                errorProvider1.SetError(fixedCostTxtBox, "Enter the cost!"); //error message in errorprovider for input
            }
            else if (num < 0)
            {
                e.Cancel = true;//don't allow focus to change
                errorProvider1.SetError(fixedCostTxtBox, "Enter a non-negative cost!"); //error message in errorprovider for input
            }
        }

        //precondition: fixed cost validtaing succeeded
        //postcondition: error messages are cleared and the focus is allowed to change.
        private void fixedCostTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTxtBox, ""); //clears error message
        }

        //precondition: attempt to change focuse from the destaddrbomcobox
        //postcondition: If the value entered is selected from the combo box, the focus will change. Otherwise, the errorprovider will show an error next to the control
        private void destAddrComBox_Validating(object sender, CancelEventArgs e)
        {
            if (destAddrComBox.SelectedIndex == -1)
            {
                e.Cancel = true; //don't allow focus to change
                errorProvider1.SetError(destAddrComBox, "Select a destination!");
            }
            else if (destAddrComBox.SelectedIndex == originAddrComBox.SelectedIndex)
            {
                e.Cancel = true; //don't allow focus to change
                errorProvider1.SetError(destAddrComBox, "Select a different destination!");
            }
        }

        //precondition: dest address validation succeeded
        //postcondition: error messages are cleared, focus is allowed to change.
        private void destAddrComBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destAddrComBox, ""); //clears error message
        }

        //precondition: attempt to change focus from origin combo box
        //postcondition: If the value entered is selected from the combo box, the focus will change. Otherwise, the errorprovider will show an error next to the control
        private void originAddrComBox_Validating(object sender, CancelEventArgs e)
        {
            if(originAddrComBox.SelectedIndex == -1)
            {
                e.Cancel = true; //don't allow focus to change
                errorProvider1.SetError(originAddrComBox, "Select and origin!");
            }
        }

        //precondition: validating succeeded pn origin address combo box
        //postcondition: error messages are cleared, focus is allowed to change.
        private void originAddrComBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originAddrComBox, ""); //clears error message
        }

        //precondition: user initiated click on createLettrBttn
        //postcondition: all inputs are validated, if validation succeeds on all, the data is passed to main form.
        private void createLttrBttn_Click(object sender, EventArgs e)
        {
            OriginAddress = (Address)originAddrComBox.SelectedItem; //sets properties, this allows main form to pull data when DialogResult == ok
            DestAddress = (Address)destAddrComBox.SelectedItem;
            FixedCost = fixedCostTxtBox.Text;
            if (this.ValidateChildren())
            { this.DialogResult = DialogResult.OK; }
        }

        //precondition: user initiates click on cancel button
        //postcondition: dialog box is closed, no data is passed.
        private void cnclBttn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
