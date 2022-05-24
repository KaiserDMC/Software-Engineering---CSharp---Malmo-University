/* Assignment 5 - by ...KaiserDMC...
   Current date: 2020-12-20
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    //Class used for filling in the Customer information. All methods here are handling various tasks needed for the Customer
    //This class serves more as a template for how the different customers should be read and stored inside the Customer Manager
    //The Customer class uses a Contact class as a template to save the data as. All methods here tackle tasks for single customer only.
    class Customer
    {
        private ContactFiles.Contact m_contact; //Contact variable/information of the customer
        private string m_id; //Customer ID variable

        public ContactFiles.Contact ContactData //Contact Data properties
        {
            get { return m_contact; }
            set { m_contact = value; }
        }

        public string ID //ID properties
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public Customer() //Default constructor
        {
        }
        public Customer(ContactFiles.Contact contactIn, string id) //Constructor for the Customer, with 2 parameters
        {
            m_contact = contactIn;
            m_id = id;
        }

        public override string ToString() //Formats the string in which the information for the Customer will be displayed inside the List
        {
            string strOut = string.Format("{0} {1}", m_id, m_contact.ToString());
            return strOut;
        }

    }
}
