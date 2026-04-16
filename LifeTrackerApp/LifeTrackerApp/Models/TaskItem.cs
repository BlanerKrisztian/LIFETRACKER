using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrackerApp.Models
{
    internal class TaskItem
    {
        private static int ID { get; set; }
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; private set; } = DateTime.Now;

        public TaskItem(string title, string priority, DateTime duedate)
        {
            if (title.Trim() == "" || !(priority != "Low" || priority != "Medium" || priority != "High") || DateTime.Now > duedate)
            {
                throw new ArgumentException();
            }

        }
    }
}
