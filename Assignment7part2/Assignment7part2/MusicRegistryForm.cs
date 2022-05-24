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
    //Class used for the Music Registry section. All methods here are handling various tasks needed for the Music Registry Form
    public partial class MusicRegistryForm : Form
    {
        MusicManager musicMngr = new MusicManager(); //creating and object of the Music Manager

        public MusicRegistryForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            lblMusicID.Text = "ID";
            lblBandName.Text = "Band Name";
            lblAlbumnYear.Text = "Year";
            lblAlbumnName.Text = "Albumn";
            lblRecordLabelName.Text = "Record Label";
            lblMusicRecordType.Text = "Record Type";
            lstMusicRegistry.Font = new Font(FontFamily.GenericMonospace, lstMusicRegistry.Font.Size, FontStyle.Regular); //List box text formatting
            toolTipMusic.SetToolTip(btnSaveMusicRegistry, "Click to save the Music Registry List to a .txt file.");
            toolTipMusic.SetToolTip(btnMusicRent, "Click to Rent a Music Record to a customer.");
            toolTipMusic.SetToolTip(btnMusicReturn, "Click to mark a Music Record as Returned by a customer.");
        }

        public void UpdateMusicList() //UpdateGUI method aka Update Music List
        {
            //Method is used for updating the list after a change to one of the music records
            lstMusicRegistry.Items.Clear();
            lstMusicRegistry.Items.AddRange(musicMngr.GetMusicInfo());
        }

        public void ClearMusicList() //Clear Method, used to clear the list and manager
        {
            lstMusicRegistry.Items.Clear();
            musicMngr.GetMusicRecords().Clear();
        }

        private void btnAddMusic_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            MusicRecord newMusic = new MusicRecord(new InformationClasses.Music(), musicMngr.GetNewID()); //Assign a new music record with Music class and ID

            MusicForm frmMusic = new MusicForm(newMusic.MusicData); //Open the Music Form with the incoming music record data, empty form
            if (frmMusic.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Music Form
            {
                this.musicMngr.AddMusic(newMusic); //Add the new music record to the Music Manager
                this.UpdateMusicList(); //Update the list
            }
        }

        private void btnChangeMusic_Click(object sender, EventArgs e) //Execute on clicking button "Change"
        {
            int editIndex = lstMusicRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (editIndex >= 0)
            {
                MusicRecord music = this.musicMngr.GetMusic(lstMusicRegistry.SelectedIndex); //get a music record at the selected index of the list
                MusicForm frmMusic = new MusicForm(music.MusicData); //Open the Music Form with the incoming music record data, form containing previous information

                if (frmMusic.ShowDialog() == DialogResult.OK) //If the user clicks OK inside the Music Form
                {
                    this.UpdateMusicList(); //Update the list
                }
            }
            else
                MessageBox.Show("Please select a Music item from the list before you press the \"Change\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music record is selected by the user
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {
            int index = lstMusicRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (index >= 0)
            {
                lstMusicRegistry.Items.RemoveAt(index); //Delete music record inside the list box
                musicMngr.DeleteMusic(index); //Delete music record inside the music record database
                for (int i = 0; i < musicMngr.Count; i++) //Loop to update the ID of the music records after deletion
                {
                    MusicRecord music = this.musicMngr.GetMusic(i);
                    music.ID = "A" + (i + 1);
                }

                UpdateMusicList(); //Update the List/GUI, although delete does that automatically most of the time
            }
            else
                MessageBox.Show("Please select a Music item from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music record is selected by the user
        }

        private bool ResultFromClosingDialog() 
        {
            //Shows a warning to the user every time he tries to exit the program; Upon selecting OK the application will close, else user will see the main form once again
            bool cancel = false;
            var dlgResult = MessageBox.Show("Would you like to exit the Music Registry", "Double check", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                cancel = true;
            }
            return cancel;
        }

        private void MusicRegistryForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless he confirms
        {
            e.Cancel = !ResultFromClosingDialog();
        }

        private void btnMusicRent_Click(object sender, EventArgs e) //Execute on clicking button "Rent"
        {
            //Switches to MANUAL drawing mode; Changes the colour of the selected item to Red;
            //Has a minor bug, as once switched to MANUAL every item that is selected afterwards will be made RED;
            //Switching back to AUTOMATIC will revert the changes. The "bug" is due to ListBox's features;
            //In ListView Fore/Back ground colours could be selected for each element, unlike for ListBox.

            //The User is also presented with a message the item has been rented
            int drawIndex = lstMusicRegistry.SelectedIndex;  //Make sure the user has selected an item from the list
            if (drawIndex >= 0)
            {
                lstMusicRegistry.DrawMode = DrawMode.OwnerDrawFixed;
                lstMusicRegistry.DrawItem += new DrawItemEventHandler(lstMusicRegistryRent_DrawItem);
                MessageBox.Show("The music record has been rented out to a customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Information message to user
            }
            else
                MessageBox.Show("Please select a Music record from the list before you press the \"Rent\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music record is selected by the user
        }

        private void lstMusicRegistryRent_DrawItem(object sender, DrawItemEventArgs e) //Custom Drawing routine for Rent
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            if (e.Index == lstMusicRegistry.SelectedIndex)
            {
                myBrush = Brushes.Red;
            }
            else
            {
                myBrush = Brushes.Black;
            }

            //Alternative of the loop presented above. Still has same minor bug due to ListBox control properties
            //if (e.Index > -1)
            //{
            //    myBrush = Brushes.Black;
            //    if(e.Index == lstMusicRegistry.SelectedIndex)
            //    {
            //        myBrush = Brushes.Red;
            //    }
            //}
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void btnMusicReturn_Click(object sender, EventArgs e) //Execute on clicking button "Return"
        {
            //Switches to MANUAL drawing mode; Changes the colour of the selected item to Black;
            //Has a minor bug, as once switched to MANUAL every item that is selected afterwards will be made Black;
            //Switching back to AUTOMATIC will revert the changes. The "bug" is due to ListBox's features;
            //In ListView Fore/Back ground colours could be selected for each element, unlike for ListBox.

            //The User is also presented with a message the item has been returned
            int drawIndex = lstMusicRegistry.SelectedIndex; //Make sure the user has selected an item from the list
            if (drawIndex >= 0)
            {
                lstMusicRegistry.DrawMode = DrawMode.OwnerDrawFixed;
                lstMusicRegistry.DrawItem += new DrawItemEventHandler(lstMusicRegistryReturn_DrawItem);
                MessageBox.Show("The music record has been returned to the store!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Information message to user
            }
            else
                MessageBox.Show("Please select a Music Record from the list before you press the \"Return\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music record is selected by the user
        }

        private void lstMusicRegistryReturn_DrawItem(object sender, DrawItemEventArgs e) //Custom Drawing routine for Return
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            Brush myBrush = Brushes.Gray;
            if (e.Index == lstMusicRegistry.SelectedIndex)
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

        private void btnSaveMusicRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Save"
        {
            if (lstMusicRegistry.Items.Count > 0) //Check if there are items in the ListBox
            {
                using (TextWriter TW = new StreamWriter("Music_Registry.txt")) //Saves the listbox items to .txt file inside "\bin\Debug"
                {
                    foreach (string itemText in lstMusicRegistry.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

                Process.Start("Music_Registry.txt"); //Opens the .txt file
            }
            else
                MessageBox.Show("Please write at least one Music Record inside the list before you press the \"Save\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no music record is written inside the list
        }
    }
}
