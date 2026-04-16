using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrackerApp.Models
{
    public class TaskItem
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; private set; } = DateTime.Now;

        public TaskItem(int ID, string title, string priority, DateTime duedate)
        {
            if (title.Trim() == "")
            {
                throw new ArgumentException("title");
            }
            if (!(priority != "Low" || priority != "Medium" || priority != "High"))
            {
                throw new ArgumentException("priority");
            }
            /*if (DateTime.Now > duedate)
            {
                throw new ArgumentException("duedate");
            }*/
            Title = title;
            Priority = priority;
            DueDate = duedate;
            Id = ID;

        }
    }
}
