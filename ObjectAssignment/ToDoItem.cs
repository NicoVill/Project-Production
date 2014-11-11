using System;
using System.Collections.Generic;

// Description on this class => look at Controller for inspiration

namespace ObjectAssignment
{
    public class ToDoItem
    {
        List<Task> tasks;

        string shortdes;
        string longdes;
        DateTime deadline;
        string taskDes;
        bool finished;
        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            tasks = new List<Task>();

            shortdes = shortDescription;
            longdes = longDescription;
            deadline = itemDeadline;

            Task newT = new Task(firstTaskDescription);
            tasks.Add(newT);

             finished = false;

        }

        public void AddTask(string TaskDescription)
        {
            tasks.Add(new Task(TaskDescription));
        }

        public bool ItemFinished()
        {
            int i = 0;
            do
            {

                if (tasks[0].ItemFinished() == true)
                {
                    return true;
                }
                i++;
            } while (tasks[i].ItemFinished() == true);
                return false;
        }

        public bool DeadlineExceeded()
        {
            if (Helper.DeadlineExceeded(deadline) == true)
            {
                return true;
            }

            return false;
        }

        public string GetItemReport()
        {
            string itemReport = "";
            

            foreach (Task t in tasks)
            {
                if (t.ItemFinished() == true)
                {
                    itemReport += "[" +  t.getTask() + "]";
                }
                else
                {
                    itemReport += t.getTask() + "\n";
                }
            }
            itemReport = "Short Description: " + shortdes + "\n" + "long Description: " + "\n" + "DeadLine: " + deadline;
                return itemReport;
        }
    }
}
