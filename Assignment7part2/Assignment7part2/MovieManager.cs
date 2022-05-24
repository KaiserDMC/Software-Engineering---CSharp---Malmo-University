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
    //Manager class used to store all Movies inside a list of MovieRecords by utilizing the methods inside it
    class MovieManager
    {
        private List<MovieRecord> m_movies; //A list of MovieRecords to store the records

        public MovieManager() //Initialization of the Manager
        {
            m_movies = new List<MovieRecord>(); //Initialization of the array/list
        }

        public int Count //Property to find the count of the movies inside the list
        {
            get { return m_movies.Count; }
        }

        public bool CheckIndex(int index) //Index check... To make sure we are not out of range
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= m_movies.Count)
                goodIndex = true;
            return goodIndex;
        }

        public bool AddMovie(MovieRecord movieIn) //Add a MovieRecord to the manager
        {
            m_movies.Add(movieIn); //Add a movie to the manager list
            return true;
        }

        public bool ChangeMovie(MovieRecord movieIn, int index) //Find the position where a movie record is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
            {
                var currentMovie = m_movies[index];
                currentMovie.MoviesData = movieIn.MoviesData;
                currentMovie.ID = movieIn.ID;
            }
            else
                edit = false;
            return edit;
        }

        public bool DeleteMovie(int index) //Find the position where a movie record is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                m_movies.RemoveAt(index);
            else
                delete = false;
            return delete;
        }

        public string[] GetMoviesInfo() //Convert all items inside the list to an array of strings
        {
            string[] moviesAsString = new string[m_movies.Count];
            for (int i = 0; i < m_movies.Count; i++)
            {
                if (m_movies[i] == null)
                    break;

                moviesAsString[i] = m_movies[i].ToString();
            }

            return moviesAsString;
        }

        public MovieRecord GetMovie(int index) //Get a movie record at certain index
        {
            return m_movies[index];
        }

        public List<MovieRecord> GetMovieRecords() //Get all music records, used to clear the manager
        {
            return m_movies;
        }

        public string GetNewID() //Get a ID for the movie records, with custom format
        {
            const string startID = "V"; //"V" stands for Video
            return startID + (m_movies.Count + 1).ToString();
        }
    }
}
