/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7part2
{
    //Class used for the Movie Form section. All methods here are handling various tasks needed for the Movie Form
    public partial class MovieForm : Form
    {
        private InformationClasses.Movies m_movies; //creating and object of the Movies class
        private bool m_closeForm; //Variable needed for the Closing Form dialog 
        public MovieForm() //Form initialization and default constructor of MusicForm class
        {
            InitializeComponent();
        }

        public MovieForm(InformationClasses.Movies movies) : this() //GUI Initialization... Assigns the default values for all fields... and 2nd constructor of MovieForm
        {
            this.m_movies = movies;
            InitializeGUI(); //Calls Initialize GUI method
        }

        private void InitializeGUI() //Initialize GUI method used to give default values
        {
            m_closeForm = true; //Changes the value to true, i.e. upon choosing OK the form will close 
            cmbMovieRecordType.DataSource = Enum.GetNames(typeof(MovieRecordType)); //Assign the Enum as datasource of the combo box
            dateTimePickerMovieDate.Format = DateTimePickerFormat.Custom; //Change format of the date-Time-Picker
            dateTimePickerMovieDate.CustomFormat = "yyyy";

            if (this.m_movies == null) //In case no index is selected or list is empty this will load empty form, so the user can fill the information
            {
                txtMovieName.Text = string.Empty;
                txtDirectorName.Text = string.Empty;
                txtStudioName.Text = string.Empty;
                dateTimePickerMovieDate.Value = DateTime.Now;
            }
            else //In case the user selects an existing contact the ContactForm will load with the existing information so the user can access and edit the latter
            {
                txtMovieName.Text = m_movies.MovieName;
                txtDirectorName.Text = m_movies.DirectorName;
                txtStudioName.Text = m_movies.StudioName;
                cmbMovieRecordType.Text = this.m_movies.Type.ToString();
                //dateTimePickerMovieDate.Value = m_movies.Date;
            }
        }

        private void btnContactOK_Click(object sender, EventArgs e) //Execute on clicking button "OK" inside Music Form
        {
            //Takes the information the user has already filled in and adds it to the movie manager and the list, updates the GUI
            m_movies.MovieName = txtMovieName.Text.Trim();
            m_movies.DirectorName = txtDirectorName.Text.Trim();
            m_movies.StudioName = txtStudioName.Text.Trim();
            m_movies.Type = (MovieRecordType)cmbMovieRecordType.SelectedIndex;
            m_movies.Date = dateTimePickerMovieDate.Value;


            if (!this.m_movies.Validate()) //Perform the Movie Validation; If no Movie Name is given provide the user with error
                this.m_closeForm = false;
            else
                this.m_closeForm = true;
        }

        private void btnContactCancel_Click(object sender, EventArgs e) //Execute on clicking button "Cancel" inside Music Form
        {
            //Will ask the customer if they want to exit the Movie Form without saving; Yes will close the form, No will return back to the Movie Form
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to cancel without saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
                m_closeForm = true;
            else
                m_closeForm = false;
        }

        private void MovieForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless they confirm
        {
            if (m_closeForm)
                e.Cancel = false; //Close the Movie Form
            else
                e.Cancel = true; //Do not close (user has chosen Cancel)
        }
    }
}
