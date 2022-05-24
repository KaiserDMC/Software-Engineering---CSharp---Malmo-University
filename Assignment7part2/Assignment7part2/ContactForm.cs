/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
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
    //Class used for the Contact Form section. All methods here are handling various tasks needed for the Contact Form
    public partial class ContactForm : Form
    {
        private InformationClasses.Contact m_contact; //creating and object of the Contact class

        private bool m_closeForm; //Variable needed for the Closing Form dialog 
        public ContactForm() //Form initialization and default constructor of ContactForm class
        {
            InitializeComponent();
        }

        public ContactForm(InformationClasses.Contact contact) : this() //GUI Initialization... Assigns the default values for all fields... and 2nd constructor of ContactForm
        {
            this.m_contact = contact;
            InitializeGUI(); //Calls Initialize GUI method
        }

        private void InitializeGUI() //Initialize GUI method used to give default values
        {
            m_closeForm = true; //Changes the value to true, i.e. upon choosing OK the form will close 

            if (this.m_contact == null) //In case no index is selected or list is empty this will load empty form, so the user can fill the information
            {
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtHomePhone.Text = string.Empty;
                txtWorkPhone.Text = string.Empty;
                txtPrivateEmail.Text = string.Empty;
                txtWorkEmail.Text = string.Empty;
            }
            else //In case the user selects an existing contact the ContactForm will load with the existing information so the user can access and edit the latter
            {
                txtFirstName.Text = this.m_contact.FirstName;
                txtLastName.Text = this.m_contact.LastName;
                txtHomePhone.Text = this.m_contact.PhoneData.Home;
                txtWorkPhone.Text = this.m_contact.PhoneData.Work;
                txtPrivateEmail.Text = this.m_contact.EmailData.Personal;
                txtWorkEmail.Text = this.m_contact.EmailData.Work;
            }
        }

        private void btnContactOK_Click(object sender, EventArgs e) //Execute on clicking button "OK" inside Contact Form
        {
            //Takes the information the user has already filled in and adds it to the customer manager and the list, updates the GUI
            m_contact.FirstName = txtFirstName.Text.Trim();
            m_contact.LastName = txtLastName.Text.Trim();
            m_contact.PhoneData.Home = txtHomePhone.Text.Trim();
            m_contact.PhoneData.Work = txtWorkPhone.Text.Trim();
            m_contact.EmailData.Personal = txtPrivateEmail.Text.Trim();
            m_contact.EmailData.Work = txtWorkEmail.Text.Trim();

            if (!this.m_contact.PhoneData.Validate(m_contact.PhoneData.Home) || !this.m_contact.PhoneData.Validate(m_contact.PhoneData.Work)) //Perform the Address Validation; If country and city are given close the form, else provide the user with error
                this.m_closeForm = false;
            else
                this.m_closeForm = true;
        }

        private void btnContactCancel_Click(object sender, EventArgs e) //Execute on clicking button "Cancel" inside Contact Form
        {
            //Will ask the customer if they want to exit the Contact Form without saving; Yes will close the form, No will return back to the Contact Form
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to cancel without saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
                m_closeForm = true;
            else
                m_closeForm = false;
        }

        private void ContactForm_FormClosing_1(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless he confirms
        {
            if (m_closeForm)
                e.Cancel = false; //Close the Contact Form
            else
                e.Cancel = true; //Do not close (user has chosen Cancel)
        }
    }
}
