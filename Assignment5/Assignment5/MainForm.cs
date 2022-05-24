/* Assignment 5 - by ...KaiserDMC...
   Current date: 2020-12-20
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    //Class used for the Main Form section. All methods here are handling various tasks needed for the Main Form
    public partial class MainForm : Form
    {
        CustomerManager customerMngr = new CustomerManager(); //creating and object of the Customer Manager

        public MainForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            lblID.Text = "ID";
            lblName.Text = "Name (Surname, Given name)";
            lblAddress.Text = "Address (Street, Zip Code, City, Country)";
            lblPhone.Text = "Home, Work and Other phones";
            lblMail.Text = "Private and Work email";
        }

        public void UpdateCustomerList() //UpdateGUI method aka Update Customer List
        {
            //Method is used for updating the list after a change to one of the customers
            lstCustomerRegistry.Items.Clear();
            lstCustomerRegistry.Items.AddRange(customerMngr.GetCustomersInfo());
        }

        private void btnAdd_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            Customer newCustomer = new Customer(new ContactFiles.Contact(), customerMngr.GetNewID()); //Assign a new customer with Contact class and ID

            ContactForm frmContact = new ContactForm(newCustomer.ContactData); //Open the Contact Form with the incoming customer data, empty form
            if (frmContact.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Contact Form
            {
                this.customerMngr.AddCustomer(newCustomer); //Add the new customer to the Customer Manager
                this.UpdateCustomerList(); //Update the list
            }
        }

        private void btnChange_Click(object sender, EventArgs e) //Execute on clicking button "Change"
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

        private void btnDelete_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {
            int index = lstCustomerRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (index >= 0)
            {
                lstCustomerRegistry.Items.RemoveAt(index); //Delete customer inside the list box
                customerMngr.DeleteCustomer(index); //Delete customer inside the customer database
                for (int i = index; i < customerMngr.Count; i++) //Loop to update the ID of the customers after deletion
                {
                    Customer customer = this.customerMngr.GetCustomer(i);
                    customer.ID = "CS" + (customerMngr.Count).ToString();
                }

                UpdateCustomerList(); //Update the List/GUI, although delete does that automatically most of the time
            }
            else
                MessageBox.Show("Please select a Customer from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no customer is selected by the user
        }
    }
}
