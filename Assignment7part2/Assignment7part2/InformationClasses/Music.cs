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
    //Class used for filling in the Music information. All methods here are handling various tasks needed for the Music
    //This class serves more as a template for how the different music records should be read and stored.
    //All methods here tackle tasks for single music record only.
    public class Music
    {
        private string m_bandName; //Variable for Band Name
        private string m_albumnName; //Variable for Albumn Name
        private string m_recordLabelName; //Variable for Record Label Name
        private MusicRecordType type; //Variable for Music Record Type
        private DateTime date; //Variable for date

        public DateTime Date //Date and time properties
        {
            get { return date; }
            set { date = value; }
        }

        public MusicRecordType Type //Type properties
        {
            get { return type; }
            set { type = value; }
        }

        public string BandName //Band name properties
        {
            get { return m_bandName; }
            set { m_bandName = value; }
        }

        public string AlbumnName //Albumn name properties
        {
            get { return m_albumnName; }
            set { m_albumnName = value; }
        }

        public string RecordLabelName //Record Label properties
        {
            get { return m_recordLabelName; }
            set { m_recordLabelName = value; }
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

        public Music() //Default constructor
        {

        }

        public Music(DateTime date, string bandName, string albumnName, string recordLabelName, MusicRecordType type) //2nd constructor
        {
            this.date = date;
            m_bandName = bandName;
            m_albumnName = albumnName;
            m_recordLabelName = recordLabelName;
            this.type = type;
        }

        public override string ToString() //Override of ToString to display inside the ListBox in a certain way
        {
            return $"{m_bandName,-25}" +
                   $"{m_albumnName,-15}" +
                   $"{GetDateString(),-5}" +
                   $"{m_recordLabelName,-15}" +
                   $"{GetTypeString(),-15}";
        }

        public bool Validate() //Music Validation
        {
            //Will result in error if the user does not provide a Band Name
            bool goodData = false;
            if (string.IsNullOrEmpty(m_bandName))
            {
                goodData = false;
                string m_strErrMessage = "Please provide at least a Band Name for the music!";
                MessageBox.Show(m_strErrMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music name is given by the user);
            }
            else
                goodData = true;

            return goodData;
        }
    }
}
