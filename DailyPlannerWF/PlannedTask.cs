using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerWF
{
    public class PlannedTask
    {
        public enum TaskStatus
        {
            Completed,
            Incomplete,
            Overdue
        }

        public Guid Guid { get; }
        public string Name { get; set; }

        public TimeSpan Time { get; set; }
        public TaskStatus Status { get; set; }
        public string Reminder { get; set; }

        public PlannedTask(string TaskName, TimeSpan TaskTime, TaskStatus TaskStatus, string Alert)
        {
            Guid = Guid.NewGuid();
            Name = TaskName;
            Time = TaskTime;
            Status = TaskStatus;
            Reminder = Alert;
        }

        public string[] ToStringArray()
        {
            string[] task = { Name, Time.ToString(), Reminder, Status.ToString()};
            return task;
        }
    }
}
