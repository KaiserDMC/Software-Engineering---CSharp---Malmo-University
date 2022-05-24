/* Assignment 5 - by ...KaiserDMC...
   Current date: 2020-12-20
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.ContactFiles
{
    //Class used for filling in the Address information. All methods here are handling various tasks needed for the Address
    //This class serves more as a template for how the different address should be read and stored.
    //All methods here tackle tasks for single address only.
    public class Address
    {
        private string m_street; //Street variable
        private string m_zipCode; //ZipCode variable
        private string m_city; //City variable
        private Countries m_country; //Country variable; uses Enum list of countries

        // Default constructor calling another constructor in this class.
        public Address()
        {

        }

        // Constructor - call the next constructor for reuse
        public Address(string street, string zip, string city): this(street, zip, city, Countries.Sverige)
        { 
        }

        // Constructor
        public Address(string street, string zip, string city, Countries country)
        {
            m_street = street;
            m_zipCode = zip;
            m_city = city;
            m_country = country;
        }

        public string Street //Street properties
        {
            get { return m_street; }
            set { m_street = value; }
        }

        public string City //City properties
        {
            get { return m_city; }
            set { m_city = value; }
        }

        public string ZipCode //ZipCode properties
        {
            get { return m_zipCode; }
            set { m_zipCode = value; }
        }

        public Countries Country //Country properties
        {
            get { return m_country; }
            set { m_country = value; }
        }

        //This function deletes the '_'s from country names as saved in the enum
        public string GetCountryString()
        {
            string strCountry = m_country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        //Override the ToString method to return a string made of the address detail, formated in one line.
        public override string ToString()
        {
            string strOut = string.Format("{0, -25} {1, -8} {2, -10} {3}", m_street, m_zipCode, m_city, GetCountryString());
            return strOut;
        }

        // Validate the Address data; user has to provide City and Country as a minimum to not return error
        //Since Enum is used to populate the ComboBox for the Country selection, that box will always have a value
        //Thus the check is done only for the City property of the Address
        public bool Validate() 
        {
            bool goodData = false;
            if(string.IsNullOrEmpty(m_city))
            {
                goodData = false;
                string m_strErrMessage = "Please provide at least a Country and a City for the customer's address!";
                MessageBox.Show(m_strErrMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no city is given by the user);
            }
            else
                goodData = true;
           
            return goodData;
        }
    }
}
