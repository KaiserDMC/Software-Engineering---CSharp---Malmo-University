/* Assignment 6 - by ...KaiserDMC...
   Current date: 2020-12-19
   Date of submission: 2020-12-20 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //Manager class used to store all tasks inside a list of Tasks by utilizing the methods inside it
    class TaskManager
    {
        private List<Task> taskList; //A list of Tasks to store the tasks

        public TaskManager() //Initialization of the Manager
        {
            taskList = new List<Task>(); //Initialization of the array/list
        }

        public int Count //Property to find the count of the tasks inside the list
        {
            get { return taskList.Count; }
        }

        public Task GetTask(int index) //Get a task at certain index
        {
            return taskList[index];
        }

        public List<Task> GetTasks() //Get all tasks, used to populate the list after edit inside UpdateGUI method
        {
            return taskList;
        }

        public void Add(Task task) //Add a task to the manager
        {
            taskList.Add(task); //Add a task to the manager list
            taskList.Sort((x, y) => x.Date.CompareTo(y.Date)); //Sort the tasks by date
        }

        public string[] ListToStringArray() //Convert all items inside the list to an array of strings
        {
            string[] taskArray = new string[Count];
            for (int i = 0; i < Count; i++)
                taskArray[i] = taskList[i].ToString();

            return taskArray;
        }

        public bool CheckIndex(int index) //Index check... To make sure we are not out of range
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= taskList.Count)
                goodIndex = true;
            return goodIndex;
        }

        public bool DeleteTask(int index) //Find the position where a task is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                taskList.RemoveAt(index);
            else
                delete = false;
            return delete;
        }

        public bool ChangeTask(int index, Task task) //Find the position where a task is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
            {
                var currentTask = taskList[index];
                currentTask.Date = task.Date;
                currentTask.Description = task.Description;
                currentTask.Priority = task.Priority;
            } 
            else
                edit = false;
            return edit;
        }
    }
}
