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
    //Class used for the Main Form section. All methods here are handling various tasks needed for the Main Form
    public partial class MainForm : Form
    {
        public MainForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI(); //GUI Initialization
        }

        private void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            this.Text = "Kontroll - the ultimate Audio/Video Store";
            loadToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            toolTipMainForm.SetToolTip(btnCustomerRegistry, "Click to open the Customer Registry Form.");
            toolTipMainForm.SetToolTip(btnMovieRegistry, "Click to open the Movie Registry Form.");
            toolTipMainForm.SetToolTip(btnMusicRegistry, "Click to open the Music Registry Form.");

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Execute on clicking button "About"
        {
            //Opens the About Form
            var myAboutInfo = new AboutBox();
            myAboutInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Execute on clicking button "Exit"
        {
            Close();
        }

        private bool ResultFromQuitDialog()
        {
            //Shows a warning to the user every time he tries to exit the program; Upon selecting OK the application will close, else user will see the main form once again
            bool cancel = false;
            var dlgResult = MessageBox.Show("Would you like to exit the program?", "Double check", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                InitializeGUI();
                cancel = true;
            }
            return cancel;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Form Closing Dialog; Do not close if user choses Cancel, unless he confirms
        {
            e.Cancel = !ResultFromQuitDialog();
        }

        private void btnCustomerRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Customer Registry"
        {
            CustomerRegistryForm customerRegistry = new CustomerRegistryForm();
            customerRegistry.ShowDialog();
        }

        private void clearNewRegistryToolStripMenuItem_Click(object sender, EventArgs e) //Execute on clicking button "Clear Customer Registry"
        {
            //Clears the Customer Manager
            InitializeGUI();
            CustomerRegistryForm customerRegistry = new CustomerRegistryForm();
            customerRegistry.ClearCustomerList();
        }

        private void btnMovieRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Movie Database"
        {
            MovieRegistryForm movieRegistry = new MovieRegistryForm();
            movieRegistry.ShowDialog();
        }

        private void clearNewInventoryToolStripMenuItem_Click(object sender, EventArgs e) //Execute on clicking button "Clear Movie Registry"
        {
            //Clears the Movie Manager
            InitializeGUI();
            MovieRegistryForm movieRegistry = new MovieRegistryForm();
            movieRegistry.ClearMovieList();
        }

        private void btnMusicRegistry_Click(object sender, EventArgs e) //Execute on clicking button "Music Database"
        {
            MusicRegistryForm musicRegistry = new MusicRegistryForm();
            musicRegistry.ShowDialog();
        }

        private void clearNewInventoryToolStripMenuItem1_Click(object sender, EventArgs e) //Execute on clicking button "Clear Music Registry"
        {
            //Clears the Music Manager
            InitializeGUI();
            MusicRegistryForm musicRegistry = new MusicRegistryForm();
            musicRegistry.ClearMusicList();
        }

    }
}
