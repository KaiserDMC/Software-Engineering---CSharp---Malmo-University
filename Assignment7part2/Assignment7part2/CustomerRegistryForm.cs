/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7part2
{
    //Class used for the Customer Registry section. All methods here are handling various tasks needed for the Customer Registry Form
    public partial class CustomerRegistryForm : Form
    {
        CustomerManager customerMngr = new CustomerManager(); //creating and object of the Customer Manager
        public CustomerRegistryForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            lblCustomerID.Text = "ID";
            lblCustomerName.Text = "Name (Surname, Given name)";
            lblCustomerPhone.Text = "Home and Work phones";
            lblCustomerEmail.Text = "Private and Work email";
            lstCustomerRegistry.Font = new Font(FontFamily.GenericMonospace, lstCustomerRegistry.Font.Size, FontStyle.Regular); //List box text formatting
            toolTipCustomer.SetToolTip(btnSaveCustomerRegistry, "Click to save the Customer Registry List to a .txt file.");
        }

        public void UpdateCustomerList() //UpdateGUI method aka Update Customer List
        {
            //Method is used for updating the list after a change to one of the customers
            lstCustomerRegistry.Items.Clear();
            lstCustomerRegistry.Items.AddRange(customerMngr.GetCustomersInfo());
        }
        
        public void ClearCustomerList() //Clear Method, used to clear the list and manager
        {
            lstCustomerRegistry.Items.Clear();
            customerMngr.GetCustomerRecords().Clear();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            Customer newCustomer = new Customer(new InformationClasses.Contact(), customerMngr.GetNewID()); //Assign a new customer with Contact class and ID

            ContactForm frmContact = new ContactForm(newCustomer.ContactData); //Open the Contact Form with the incoming customer data, empty form
            if (frmContact.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Contact Form
            {
                this.customerMngr.AddCustomer(newCustomer); //Add the new customer to the Customer Manager
                this.UpdateCustomerList(); //Update the list
            }
        }

        private void btnChangeCustomer_Click(object sender, EventArgs e) //Execute on clicking button "Change"
        {

            int editIndex = lstCustomerRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (editIndex >= 0)
            {
                Customer customer = this.customerMngr.GetCustomer(lstCustomerRegistry.SelectedIndex); //get a customer at the selected index of the list
                ContactForm frmContact = new ContactForm(customer.ContactData); //Open the Contact Form with the incoming customer data, form containing previous information

                if (frmContact.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Contact Form
                {
                    this.UpdateCustomerList(); //Update the list
                }
            }
            else
                MessageBox.Show("Please select a Customer from the list before you press the \"Change\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no customer is selected by the user
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {

            int index = lstCustomerRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (index >= 0)
            {
                lstCustomerRegistry.Items.RemoveAt(index); //Delete customer inside the list box
                customerMngr.DeleteCustomer(index); //Delete customer inside the customer database
                for (int i = 0; i < customerMngr.Count; i++) //Loop to update the ID of the customers after deletion
                {
                    Customer customer = this.customerMngr.GetCustomer(i);
                    customer.ID = "K" + (i + 1);
                }

                UpdateCustomerList(); //Update the List/GUI, although delete does that automatically most of the time
            }
            else
                MessageBox.Show("Please select a Customer from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no customer is selected by the user

        }

        private bool ResultFromClosingDialog()
        {
            //Shows a warning to the user every time he tries to exit the program; Upon selecting OK the application will close, else user will see the main form once again
            bool cancel = false;
            var dlgResult = MessageBox.Show("Would you like to exit the Customer Registry", "Double check", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                cancel = true;
            }
            return cancel;
        }

        private void CustomerRegistryForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless he confirms
        {
            e.Cancel = !ResultFromClosingDialog();
        }

        private void btnSaveCustomerRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Save"
        {
            if (lstCustomerRegistry.Items.Count > 0) //Check if there are items in the ListBox
            {
                using (TextWriter TW = new StreamWriter("Customer_Registry.txt")) //Saves the listbox items to .txt file inside "\bin\Debug"
                {
                    foreach (string itemText in lstCustomerRegistry.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

                Process.Start("Customer_Registry.txt"); //Opens the .txt file
            }
            else
                MessageBox.Show("Please write at least one customer inside the list before you press the \"Save\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no customer is written inside the list
        }
    }

}
