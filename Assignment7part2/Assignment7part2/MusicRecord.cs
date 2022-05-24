/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7part2
{
    //Class used for filling in the Music Record information. All methods here are handling various tasks needed for the Music Record
    //This class serves more as a template for how the different music records should be read and stored inside the Music Manager
    //The Music Record class uses a Music class as a template to save the data as. All methods here tackle tasks for single music record only.
    class MusicRecord
    {
        private InformationClasses.Music m_music; //Music variable/information of the music record
        private string m_id; //Music ID variable

        public InformationClasses.Music MusicData //Music Data properties
        {
            get { return m_music; }
            set { m_music = value; }
        }

        public string ID //ID properties
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public MusicRecord() //Default constructor
        {
        }
        public MusicRecord(InformationClasses.Music musicIn, string id) //Constructor for the Music Record, with 2 parameters
        {
            m_music = musicIn;
            m_id = id;
        }

        public override string ToString() //Formats the string in which the information for the Music Record will be displayed inside the List
        {
            string strOut = string.Format("{0} {1}", m_id, m_music.ToString());
            return strOut;
        }

    }
}
