/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.IO;
using System.Diagnostics;
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
    //Class used for the Movie Registry section. All methods here are handling various tasks needed for the Movie Registry Form
    public partial class MovieRegistryForm : Form
    {
        MovieManager movieMngr = new MovieManager(); //creating and object of the Movie Manager
        public MovieRegistryForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            lblMovieID.Text = "ID";
            lblMovieName.Text = "Movie Name";
            lblMovieYear.Text = "Year";
            lblMovieDirector.Text = "Director";
            lblMovieStudio.Text = "Studio";
            lblMovieRecordType.Text = "Record Type";
            lstMovieRegistry.Font = new Font(FontFamily.GenericMonospace, lstMovieRegistry.Font.Size, FontStyle.Regular); //List box text formatting
            toolTipMovie.SetToolTip(btnSaveMovieRegistry, "Click to save the Movie Registry List to a .txt file.");
            toolTipMovie.SetToolTip(btnMovieRent, "Click to Rent a Movie to a customer.");
            toolTipMovie.SetToolTip(btnMovieReturn, "Click to mark a Movie as Returned by a customer.");
        }

        public void UpdateMovieList() //UpdateGUI method aka Update Movie List
        {
            //Method is used for updating the list after a change to one of the movies
            lstMovieRegistry.Items.Clear();
            lstMovieRegistry.Items.AddRange(movieMngr.GetMoviesInfo());
        }

        public void ClearMovieList() //Clear Method, used to clear the list and manager
        {
            lstMovieRegistry.Items.Clear();
            movieMngr.GetMovieRecords().Clear();
        }

        private void btnAddMovie_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            MovieRecord newMovie = new MovieRecord(new InformationClasses.Movies(), movieMngr.GetNewID()); //Assign a new movie with Movie class and ID

            MovieForm frmMovie = new MovieForm(newMovie.MoviesData); //Open the Movie Form with the incoming movie data, empty form
            if (frmMovie.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Movie Form
            {
                this.movieMngr.AddMovie(newMovie); //Add the new movie to the Movie Manager
                this.UpdateMovieList(); //Update the list
            }
        }

        private void btnChangeMovie_Click(object sender, EventArgs e) //Execute on clicking button "Change"
        {

            int editIndex = lstMovieRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (editIndex >= 0)
            {
                MovieRecord movie = this.movieMngr.GetMovie(lstMovieRegistry.SelectedIndex); //get a movie at the selected index of the list
                MovieForm frmMovie = new MovieForm(movie.MoviesData); //Open the Movie Form with the incoming movie data, form containing previous information

                if (frmMovie.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Contact Form
                {
                    this.UpdateMovieList(); //Update the list
                }
            }
            else
                MessageBox.Show("Please select a Movie from the list before you press the \"Change\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie is selected by the user
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {

            int index = lstMovieRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (index >= 0)
            {
                lstMovieRegistry.Items.RemoveAt(index); //Delete movie inside the list box
                movieMngr.DeleteMovie(index); //Delete movie inside the movie database
                for (int i = 0; i < movieMngr.Count; i++) //Loop to update the ID of the movies after deletion
                {
                    MovieRecord movie = this.movieMngr.GetMovie(i);
                    movie.ID = "V" + (i + 1);
                }

                UpdateMovieList(); //Update the List/GUI, although delete does that automatically most of the time
            }
            else
                MessageBox.Show("Please select a Movie from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie is selected by the user
        }

        private bool ResultFromClosingDialog()
        {
            //Shows a warning to the user every time he tries to exit the program; Upon selecting OK the application will close, else user will see the main form once again
            bool cancel = false;
            var dlgResult = MessageBox.Show("Would you like to exit the Movie Registry", "Double check", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                cancel = true;
            }
            return cancel;
        }

        private void MovieRegistryForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless he confirms
        {
            e.Cancel = !ResultFromClosingDialog();
        }

        private void btnMovieRent_Click(object sender, EventArgs e) //Execute on clicking button "Rent"
        {
            //Switches to MANUAL drawing mode; Changes the colour of the selected item to Red;
            //Has a minor bug, as once switched to MANUAL every item that is selected afterwards will be made RED;
            //Switching back to AUTOMATIC will revert the changes. The "bug" is due to ListBox's features;
            //In ListView Fore/Back ground colours could be selected for each element, unlike for ListBox.

            //The User is also presented with a message the item has been rented
            int drawIndex = lstMovieRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (drawIndex >= 0)
            {
                lstMovieRegistry.DrawMode = DrawMode.OwnerDrawFixed;
                lstMovieRegistry.DrawItem += new DrawItemEventHandler(lstMovieRegistryRent_DrawItem);
                MessageBox.Show("The movie has been rented out to a customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Information message to user
            }
            else
                MessageBox.Show("Please select a Movie from the list before you press the \"Rent\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie is selected by the user
        }

        private void lstMovieRegistryRent_DrawItem(object sender, DrawItemEventArgs e)  //Custom Drawing routine for Rent
        {
                // Draw the background of the ListBox control for each item.
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                if (e.Index == lstMovieRegistry.SelectedIndex)
                {
                    myBrush = Brushes.Red;
                }
                else
                {
                    myBrush = Brushes.Black;
                }
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                      e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();           
        }

        private void btnMovieReturn_Click(object sender, EventArgs e)
        {
            //Switches to MANUAL drawing mode; Changes the colour of the selected item to Black;
            //Has a minor bug, as once switched to MANUAL every item that is selected afterwards will be made Black;
            //Switching back to AUTOMATIC will revert the changes. The "bug" is due to ListBox's features;
            //In ListView Fore/Back ground colours could be selected for each element, unlike for ListBox.

            //The User is also presented with a message the item has been returned
            int drawIndex = lstMovieRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (drawIndex >= 0)
            {
                lstMovieRegistry.DrawMode = DrawMode.OwnerDrawFixed;
                lstMovieRegistry.DrawItem += new DrawItemEventHandler(lstMovieRegistryReturn_DrawItem);
                MessageBox.Show("The movie has been returned to the store!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Information message to user
            }
            else
                MessageBox.Show("Please select a Movie from the list before you press the \"Return\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie is selected by the user
        }

        private void lstMovieRegistryReturn_DrawItem(object sender, DrawItemEventArgs e) //Custom Drawing routine for Return
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            Brush myBrush = Brushes.Gray;
            if (e.Index == lstMovieRegistry.SelectedIndex)
            {
                myBrush = Brushes.Black;
            }
            else
            {

            }
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();     
        }

        private void btnSaveMovieRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Save"
        {
            if(lstMovieRegistry.Items.Count > 0) //Check if there are items in the ListBox
            {
                using (TextWriter TW = new StreamWriter("Movie_Registry.txt")) //Saves the listbox items to .txt file inside "\bin\Debug"
                {
                    foreach(string itemText in lstMovieRegistry.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

                Process.Start("Movie_Registry.txt"); //Opens the .txt file
            }
            else
                MessageBox.Show("Please write at least one Movie inside the list before you press the \"Save\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no movie record is written inside the list
        }
    }
}
