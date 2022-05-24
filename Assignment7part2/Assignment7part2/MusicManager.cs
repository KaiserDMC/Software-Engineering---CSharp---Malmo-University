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
    //Manager class used to store all music records inside a list of Music Records by utilizing the methods inside it
    class MusicManager
    {
        private List<MusicRecord> m_music; //A list of MusicRecords to store the records

        public MusicManager() //Initialization of the Manager
        {
            m_music = new List<MusicRecord>(); //Initialization of the array/list
        }

        public int Count //Property to find the count of the music records inside the list
        {
            get { return m_music.Count; }
        }

        public bool CheckIndex(int index) //Index check... To make sure we are not out of range
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= m_music.Count)
                goodIndex = true;
            return goodIndex;
        }

        public bool AddMusic(MusicRecord musicIn) //Add a music record to the manager
        {
            m_music.Add(musicIn); //Add a music record to the manager list
            return true;
        }

        public bool ChangeMusic(MusicRecord musicIn, int index) //Find the position where a music record is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
            {
                var currentMusic = m_music[index];
                currentMusic.MusicData = musicIn.MusicData;
                currentMusic.ID = musicIn.ID;
            }
            else
                edit = false;
            return edit;
        }

        public bool DeleteMusic(int index) //Find the position where a music record is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                m_music.RemoveAt(index);
            else
                delete = false;
            return delete;
        }

        public string[] GetMusicInfo() //Convert all items inside the list to an array of strings
        {
            string[] musicAsString = new string[m_music.Count];
            for (int i = 0; i < m_music.Count; i++)
            {
                if (m_music[i] == null)
                    break;

                musicAsString[i] = m_music[i].ToString();
            }

            return musicAsString;
        }

        public MusicRecord GetMusic(int index) //Get a music record at certain index
        {
            return m_music[index];
        }

        public List<MusicRecord> GetMusicRecords() //Get all music records, used to clear the manager
        {
            return m_music;
        }

        public string GetNewID() //Get a ID for the music records, with custom format
        {
            const string startID = "A"; //"A" stands for Audio
            return startID + (m_music.Count + 1).ToString();
        }
    }
}
