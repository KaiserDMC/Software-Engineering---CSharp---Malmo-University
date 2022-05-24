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
    //Class used for filling in the Task information. All methods here are handling various tasks needed for the Task
    //This class serves more as a template for how the different tasks should be read and stored inside the Task Manager
    //All methods here tackle tasks for single task only.
    class Task
    {
        private DateTime date; //Date and time of the task
        private string description; //Description of the task
        private PriorityType priority; //Priority of the task

        public DateTime Date //Date and time properties
        {
            get { return date; }
            set { date = value; }
        }

        public string Description //Description properties
        {
            get { return description; }
            set { description = value; }
        }

        public PriorityType Priority //Priority properties
        {
            get { return priority; }
            set { priority = value; }
        }

        private string GetPriorityString() //Get the priority field as string, not enum and remove the "_" char
        {
            string strPriority = priority.ToString();
            strPriority = strPriority.Replace("_", " ");
            return strPriority;
        }

        private string GetTimeString() //Convert the time from the time and date picker to a "short" format time only
        {
            string strTime = date.ToShortTimeString();
            return strTime;
        }

        public Task(DateTime date, PriorityType priority, string description) //Constructor for the Task
        {
            this.date = date; //Assigns the date value to the date variable
            this.priority = priority; //Assigns the priority value to the priority variable
            this.description = description;  //Assigns the description value to the description variable
        }

        public override string ToString() //Formats the string in which the information for the Task will be displayed inside the List
        {
            return $"{date.ToShortDateString(),-12}" +
                   $"{GetTimeString(),-7}" +
                   $"{GetPriorityString(),-16}" +
                   $"{description}";
        }

    }
}
