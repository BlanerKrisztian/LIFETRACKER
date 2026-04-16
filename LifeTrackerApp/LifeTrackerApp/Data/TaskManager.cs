using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeTrackerApp.Models;

namespace LifeTrackerApp.Data
{
    public class TaskManager
    {
        static private List<TaskItem> taskItems { get; set; }
        static private int ID = 1;

        static TaskItem AddTask(string title, string priority, DateTime duedate)
        {
            TaskItem newTask = new(ID, title, priority, duedate);
            ID++;
            taskItems.Add(newTask);
            return newTask;
        }
        static bool RemoveTask(int id)
        {
            TaskItem TaskToDelete = taskItems.Where(Task => Task.Id == id).First();
            if (TaskToDelete is null)
                return false;
            taskItems.Remove(TaskToDelete);
            return true;
        }

    }
}
