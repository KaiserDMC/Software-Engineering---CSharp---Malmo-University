/* Assignment 6 - by ...KaiserDMC...
   Current date: 2020-12-19
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    //Class used for the Main Form section. All methods here are handling various tasks needed for the Main Form
    public partial class MainForm : Form
    {
        TaskManager taskManager = new TaskManager(); //creating and object of the Task Manager

        #region Initialization
        public MainForm() //Form initialization
        {
            InitializeComponent();
            InitializeGUI();
        }


        private void InitializeGUI() //GUI Initialization... Assigns the default values for all fields
        {
            ClearBoxesAndLists();
            AssignNameAndLabels();
            this.Text = "The To Do Reminder Application of Kristian Fodor";
            cmbPrio.Text = PriorityType.Normal.ToString();
            menuFileOpen.Enabled = false;
            menuFileSave.Enabled = false;
            lstToDo.Font = new Font(FontFamily.GenericMonospace, lstToDo.Font.Size, FontStyle.Regular); //List box text formatting
        }

        private void ClearBoxesAndLists() //Clears all boxes and lists inside the form; clears the "_" from the Priority type
        {
            txtToDo.Text = string.Empty;
            lstToDo.Text = string.Empty;
            cmbPrio.Items.Clear();
            string[] priority = Enum.GetNames(typeof(PriorityType));
            foreach (var item in priority)
                cmbPrio.Items.Add(item.Replace("_", " "));
        }

        private void AssignNameAndLabels() //Assigns default values/names to all labels, gives the tool tip text, shorcuts and the date and time format
        {
            lblDate.Text = "Date";
            lblDateTime.Text = "Date and time";
            lblHour.Text = "Hour";
            lblPrio.Text = "Priority";
            lblPriority.Text = lblPrio.Text;
            lblToDo.Text = "To Do";
            lblDesc.Text = "Description";
            toolTip1.SetToolTip(dateTimePicker, "Click to open calendar for date, write in the time here.");
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd       HH:mm";
            dateTimePicker.Value = DateTime.Now;
            menuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            menuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
        }
        #endregion
        private void UpdateGUI() //GUI Update... Used to refresh/update the GUI information after add/edit/delete of each task
        {
            cmbPrio.Text = PriorityType.Normal.ToString();
            txtToDo.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Upon chosing Cancel option do nothing, i.e. do not close the application
        {
            e.Cancel = !ResultFromQuitDialog();
        }

        private void menuFileExit_Click(object sender, EventArgs e) //Upon chosing Exit option close the application 
        {
            Close();
        }

        private void timerTime_Tick(object sender, EventArgs e) //Adds a clock to a label positioned at the bottom right corner; Shows info to the user about the current time
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuFileNew_Click(object sender, EventArgs e) //Upon chosing New option re-Initialize the GUI of the application 
        {
            //Restores the state of the application exactly as it was on start-up
            InitializeGUI();
            lstToDo.Items.Clear();
            taskManager.GetTasks().Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Execute on clicking button "Add"
        {
            //Takes the information the user has already filled in and adds it to the task manager and the list, updates the GUI
            if (!(txtToDo.Text == string.Empty))
            {
                Task newTask = GetTaskFromUserInputs();
                taskManager.Add(newTask);
                lstToDo.Items.Add(newTask);
                UpdateGUI();
            }
            else
                MessageBox.Show("Please provide a description for the task before you save it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no task description is given from the user

        }

        private void menuHelpAbout_Click(object sender, EventArgs e) //Execute on clicking button "About"
        {
            var myAboutInfo = new aboutBox();
            myAboutInfo.Show();
        }

        Task GetTaskFromUserInputs() //Method used to get the information from the fields the user is filling in, used inside btnAdd_Click method
        {
            PriorityType priority;
            Enum.TryParse<PriorityType>(cmbPrio.Text, out priority);

            return new Task(dateTimePicker.Value, priority, txtToDo.Text);
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

        private bool ResultFromDeleteDialog()
        {
            //Shows a warning to the user every time he tries to deletea task; Upon selecting Yes the task will be deleted, else user will see the main form once again
            bool cancel = false;
            var dlgResult = MessageBox.Show("Are you sure you wish to delete the selected item?", "Double check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                cancel = true;
            }
            return cancel;
        }

        private void btnChange_Click(object sender, EventArgs e) //Execute on clicking button "Change"
        {
            //Takes the information of the selected by the user saved task in the list and copies the information inside the fields preparing it for EDIT-ing


            int editIndex = lstToDo.SelectedIndex;
            if (editIndex >= 0)
            {
                btnChange.Enabled = false; //Disables the Change button so the user cannot click it twice
                lstToDo.Enabled = false; //Disables the List so that the user cannot change his selection once the Change button has been selected
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                Task task = taskManager.GetTask(lstToDo.SelectedIndex);
                dateTimePicker.Value = task.Date;
                cmbPrio.Text = task.Priority.ToString();
                txtToDo.Text = task.Description;
                btnSaveChanges.Visible = true; //Make the "Save Changes" button visible, this button is used to confirm the changes created by the user
            }
            else
                MessageBox.Show("Please select a Task from the list before you press the \"Change\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no task is selected by the user

        }

        private void btnDelete_Click(object sender, EventArgs e) //Execute on clicking button "Delete"
        {
            //Deletes the selected by the user task from the task manager and the list, updates the GUI
            int deleteIndex = lstToDo.SelectedIndex;
            if (deleteIndex >= 0)
            {
                bool dlgResult = ResultFromDeleteDialog();

                if (dlgResult == true)
                {
                    lstToDo.Items.RemoveAt(deleteIndex); //Delete task inside list box
                    taskManager.DeleteTask(deleteIndex); //Delete task inside the task database
                }
            }
            else
                MessageBox.Show("Please select a Task from the list before you press the \"Delete\" button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message in case no task is selected by the user
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) //Execute on clicking button "Save Changes"
        {
            //Takes the information the user has already filled in AFTER EDIT-ing the fields and adds it to the task manager and the list, updates the GUI
            //Index check is not needed as the List is disabled from the btnChange_Click method before 
            taskManager.ChangeTask(lstToDo.SelectedIndex, GetTaskFromUserInputs());
            lstToDo.Items.Clear();
            lstToDo.Items.AddRange(taskManager.GetTasks().ToArray());
            UpdateGUI();

            lstToDo.Enabled = true; //Enables the List, so the user can make another selection
            btnChange.Enabled = true; //Enables the Change button for more edits
            btnSaveChanges.Visible = false; //Hides the Save Changes button 
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
