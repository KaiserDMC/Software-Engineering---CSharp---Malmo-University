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
    //Class used for filling in the MovieRecord information. All methods here are handling various tasks needed for the Movie Record
    //This class serves more as a template for how the different movie records should be read and stored inside the Movie Manager
    //The Movie Record class uses a Movies class as a template to save the data as. All methods here tackle tasks for single movie record only.
    class MovieRecord
    {
        private InformationClasses.Movies m_movies; //Movies variable/information of the movie record
        private string m_id; //Movie ID variable

        public InformationClasses.Movies MoviesData //Movies Data properties
        {
            get { return m_movies; }
            set { m_movies = value; }
        }

        public string ID //ID properties
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public MovieRecord() //Default constructor
        {
        }
        public MovieRecord(InformationClasses.Movies movieIn, string id) //Constructor for the Movie Record, with 2 parameters
        {
            m_movies = movieIn;
            m_id = id;
        }

        public override string ToString() //Formats the string in which the information for the Movie Record will be displayed inside the List
        {
            string strOut = string.Format("{0} {1}", m_id, m_movies.ToString());
            return strOut;
        }

    }
}
