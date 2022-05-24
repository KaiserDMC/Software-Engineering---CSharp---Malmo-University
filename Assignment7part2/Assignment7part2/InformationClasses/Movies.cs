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
    //Class used for filling in the Movies information. All methods here are handling various tasks needed for the Movies
    //This class serves more as a template for how the different movie records should be read and stored.
    //All methods here tackle tasks for single movie record only.
    public class Movies
    {
        private string m_movieName; //Variable for Movie Name
        private string m_directorName; //Variable for Director Name
        private string m_studioName; //Variable for Studio Name
        private MovieRecordType type; //Variable for Movie Record Type
        private DateTime date; //Variable for date

        public DateTime Date //Date and time properties
        {
            get { return date; }
            set { date = value; }
        }

        public MovieRecordType Type //Type properties
        {
            get { return type; }
            set { type = value; }
        }

        public string MovieName //Movie Name properties
        {
            get { return m_movieName; }
            set { m_movieName = value; }
        }

        public string DirectorName //Director Name properties
        {
            get { return m_directorName; }
            set { m_directorName = value; }
        }

        public string StudioName //Studio Name properties
        {
            get { return m_studioName; }
            set { m_studioName = value; }
        }

        private string GetTypeString() //Replace the "_" with space inside the TYPE
        {
            string strType = type.ToString();
            strType = strType.Replace("_", " ");
            return strType;
        }

        private string GetDateString() //Convert the date from the time and date picker to a "short" format date only
        {
            string strDate = date.Year.ToString();
            return strDate;
        }

        public Movies() //Default constructor
        {

        }

        public Movies(DateTime date, string movieName, string directorName, string studioName, MovieRecordType type) //2nd constructor
        {
            this.date = date;
            m_movieName = movieName;
            m_directorName = directorName;
            m_studioName = studioName;
            this.type = type;
        }

        public override string ToString() //Override of ToString to display inside the ListBox in a certain way
        {
            return $"{m_movieName,-25}" +
                   $"{GetDateString(),-5}" +
                   $"{m_directorName,-15}" +
                   $"{m_studioName,-20}" +
                   $"{GetTypeString(),-10}";
        }

        public bool Validate() //Movie Validation
        {
            //Will result in error if the user does not provide a Movie Name
            bool goodData = false;
            if (string.IsNullOrEmpty(m_movieName))
            {
                goodData = false;
                string m_strErrMessage = "Please provide at least a Movie Name for the movie!";
                MessageBox.Show(m_strErrMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie name is given by the user);
            }
            else
                goodData = true;

            return goodData;
        }
    }
}
