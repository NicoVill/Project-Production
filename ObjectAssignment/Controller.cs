using System;
using System.Collections.Generic;

namespace ObjectAssignment
{
    public class Controller
    {
        //Declare the list that contains the items
        List<ToDoItem> _items;

        public Controller()
        {
            _items = new List<ToDoItem>();
        }

        public void AddNewToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            //Method that is actually used to create a new Item (used in the program.cs)
            string shortdes = shortDescription;
            string longdes = longDescription;
            DateTime deadline = itemDeadline;
            string taskDes = firstTaskDescription;

            _items.Add(new ToDoItem(shortdes, longdes, deadline, taskDes));

            // A to do item contains 
            // a short description
            // a long description
            // a deadline
            // and one or more tasks that each contains a description
        }

        /// <summary>
        /// Creates a report on Items
        /// </summary>
        /// <param name="OnlyNotfinished">True = Items that aren't finished</param>
        /// <returns>The report in one string</returns>
        public string GetAllItemReports(bool OnlyNotfinished = false)
        {
            for (int i = 0; i < _items.Count; i++ )
            {
               if (_items[0].ItemFinished() == true)
                return _items[0].GetItemReport();
            }
                return "Controller.GetAllItemReports()";
        }
    }
}
