/* Assignment 5 - by ...KaiserDMC...
   Current date: 2020-12-20
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    //Class used for filling in the Phone information. All methods here are handling various tasks needed for the Phone
    //This class serves more as a template for how the different phone should be read and stored.
    //All methods here tackle tasks for single phone only.
    public class Phone
    {
        private string m_home; //Variable for Home Phone
        private string m_other; //Variable for Other Phone
        private string m_work; //Variable for Work Phone

        public Phone () //Default Constructor
        {
        }

        public Phone (string homePhone, string workPhone, string otherPhone) //2nd Constructor
        {
            m_home = homePhone;
            m_work = workPhone;
            m_other = otherPhone; //Other phone added, despite being omitted inside the examples/help slides
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

        public string Other //Other Phone properties
        {
            get { return m_other; }
            set { m_other = value; }
        }

        public void DefaultValues() //Default values, as phone is not mandatory reverts to just empty strings if user does not provide any info
        {
            m_home = string.Empty;
            m_other = string.Empty;
            m_work = string.Empty;
        }

        public override string ToString() //Override the ToString method to return a string made of the phone details, formated in one line.
        {
            string strOut = string.Format("{0, -25} {1, -8} {2, -10}", m_home, m_work, m_other);
            return strOut;
        }

    }
}
