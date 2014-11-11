using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAssignment
{
    public class Task
    {
        //Declare the variables that is used in the class
        DateTime finishedTimestamp;
        string des;
        public Task(string description)
        {
            // A task has a description and a datetime that contains null when the task isn't finished or the date of when the task is finished 

            des = description;
            finishedTimestamp = DateTime.MinValue;
        }


        public void MarkAsFinished()
        {
            finishedTimestamp = DateTime.Now;
        }

        public bool ItemFinished()
        {
            if ( finishedTimestamp == DateTime.MinValue)
            {
                return false;
            }
            return true;
        }
        public string getTask()
        {
            return des;
        }
    }
}
