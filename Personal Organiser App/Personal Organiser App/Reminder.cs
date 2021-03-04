using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organiser_App
{
    class Reminder
    {
        public DateTime Date;
        public DateTime Time;
        public string type;
        public string summary;
        public string description;

        public Reminder(DateTime date, DateTime time, string type, string summary, string description)
        {
            Date = date;
            Time = time;
            this.type = type;
            this.summary = summary;
            this.description = description;
        }
    }
}
