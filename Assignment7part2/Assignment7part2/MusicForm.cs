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
    //Class used for the Music Form section. All methods here are handling various tasks needed for the Music Form
    public partial class MusicForm : Form
    {
        private InformationClasses.Music m_music; //creating and object of the Music class
        private bool m_closeForm; //Variable needed for the Closing Form dialog 
        public MusicForm() //Form initialization and default constructor of MusicForm class
        {
            InitializeComponent();
        }

        public MusicForm(InformationClasses.Music music) : this() //GUI Initialization... Assigns the default values for all fields... and 2nd constructor of MusicForm
        {
            this.m_music = music;
            InitializeGUI(); //Calls Initialize GUI method
        }

        private void InitializeGUI() //Initialize GUI method used to give default values
        {
            m_closeForm = true; //Changes the value to true, i.e. upon choosing OK the form will close 
            cmbMusicRecordType.DataSource = Enum.GetNames(typeof(MusicRecordType)); //Assign the Enum as datasource of the combo box
            dateTimePickerMusicDate.Format = DateTimePickerFormat.Custom; //Change format of the date-Time-Picker
            dateTimePickerMusicDate.CustomFormat = "yyyy";

            if (this.m_music == null) //In case no index is selected or list is empty this will load empty form, so the user can fill the information
            {
                txtBandName.Text = string.Empty;
                txtAlbumnName.Text = string.Empty;
                txtRecordLabelName.Text = string.Empty;
                dateTimePickerMusicDate.Value = DateTime.Now;
            }
            else //In case the user selects an existing music record the MusicForm will load with the existing information so the user can access and edit the latter
            {
                txtBandName.Text = this.m_music.BandName;
                txtAlbumnName.Text = this.m_music.AlbumnName;
                txtRecordLabelName.Text = this.m_music.RecordLabelName;
                cmbMusicRecordType.Text = this.m_music.Type.ToString();
                //dateTimePickerMusicDate.Value = this.m_music.Date;
            }
        }

        private void btnContactOK_Click(object sender, EventArgs e) //Execute on clicking button "OK" inside Music Form
        {
            //Takes the information the user has already filled in and adds it to the music manager and the list, updates the GUI
            m_music.BandName = txtBandName.Text.Trim();
            m_music.AlbumnName= txtAlbumnName.Text.Trim();
            m_music.RecordLabelName = txtRecordLabelName.Text.Trim();
            m_music.Type = (MusicRecordType)cmbMusicRecordType.SelectedIndex;
            m_music.Date = dateTimePickerMusicDate.Value;


            if (!this.m_music.Validate()) //Perform the Music Validation; If no Band Name is given provide the user with error
                this.m_closeForm = false;
            else
                this.m_closeForm = true;
        }

        private void btnContactCancel_Click(object sender, EventArgs e) //Execute on clicking button "Cancel" inside Music Form
        {
            //Will ask the user if they want to exit the Music Form without saving; Yes will close the form, No will return back to the Music Form
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to cancel without saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
                m_closeForm = true;
            else
                m_closeForm = false;
        }

        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless they confirm
        {
            if (m_closeForm)
                e.Cancel = false; //Close the Music Form
            else
                e.Cancel = true; //Do not close (user has chosen Cancel)
        }
    }
}
