using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrackerApp
{
    public class HabitRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public List<DateTime> CompletionLog { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
