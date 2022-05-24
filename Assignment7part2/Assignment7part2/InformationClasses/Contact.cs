/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7part2.InformationClasses
{
    //Class used for filling in the Contact information. All methods here are handling various tasks needed for the Contact
    //This class serves more as a template for how the different contact should be read and stored.
    //The Contact class is used by Customer class as a template to save the data as. All methods here tackle tasks for single contact only.
    public class Contact
    {
        private string m_firstName; //First name of the Contact
        private string m_lastName; //Last name of the Contact
        private Phone m_phone; //Phone of the contact; uses Phone class
        private Email m_email; //Email of the contact; uses Email class

        public Contact() //Default constructor
        {
            m_email = new Email();
            m_phone = new Phone();
        }

        public Contact(string firstName, string lastName, Phone tel, Email mail) //2nd Constructor with all parameters
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_phone = tel;
            m_email = mail;
        }

        public Email EmailData //Email properties
        {
            get { return m_email; }
            set { m_email = value; }
        }

        public Phone PhoneData //Phone properties
        {
            get { return m_phone; }
            set { m_phone = value; }
        }

        public string FirstName //First name properties
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }

        public string LastName //Last name properties
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }

        public string FullName //Combination/Formatting of First+Last name
        {
            get { return m_lastName + ", " + m_firstName; }
        }

        public override string ToString() //Formats the string in which the information for the Contact will be displayed inside the List
        {
            string strOut = string.Format("{0, -20} {1} {2}", FullName, m_phone.ToString(), m_email.ToString());
            return strOut;
        }
    }
}
