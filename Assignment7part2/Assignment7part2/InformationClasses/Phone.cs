/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Assignment7part2.InformationClasses
{
    //Class used for filling in the Phone information. All methods here are handling various tasks needed for the Phone
    //This class serves more as a template for how the different phone should be read and stored.
    //All methods here tackle tasks for single phone only.
    public class Phone
    {
        private string m_home; //Variable for Home Phone
        private string m_work; //Variable for Work Phone

        public Phone () //Default Constructor
        {
        }

        public Phone (string homePhone, string workPhone) //2nd Constructor
        {
            m_home = homePhone;
            m_work = workPhone;
        }

        public string Home //Home Phone properties
        {
            get { return m_home; }
            set { m_home = value; }
        }

        public string Work //Work Phone properties
        {
            get { return m_work; }
            set { m_work = value; }
        }

        public void DefaultValues() //Default values, as phone is not mandatory reverts to just empty strings if user does not provide any info
        {
            m_home = string.Empty;
            m_work = string.Empty;
        }

        public override string ToString() //Override the ToString method to return a string made of the phone details, formated in one line.
        {
            string strOut = string.Format("{0, -25} {1, -8}", m_home, m_work);
            return strOut;
        }

        public bool Validate(string str) //Phone Validation
        {
            //Allows only the numbers between 0 and 9 to be put inside the text field, else it will provide and error to the user
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Only the numbers 0-9 can be used for Home and Work Phone fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case not only numbers 0-9 are used for phone;
                    return false;
                }
            }

            return true;
        }
    }
}
