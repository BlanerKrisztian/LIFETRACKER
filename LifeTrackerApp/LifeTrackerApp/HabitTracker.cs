using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using LifeTrackerApp.Models;

namespace LifeTrackerApp
{
    public class HabitTracker
    {
        List<HabitRecord> Habits = new List<HabitRecord>();
        public HabitRecord AddHabit(string name, string frequency)
        {
            Habits.Append(new HabitRecord { Id = 0, Name = name, Frequency = frequency, CompletionLog = [], CreatedAt = DateTime.Now });
        }
    }
}
