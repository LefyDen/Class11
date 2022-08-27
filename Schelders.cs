using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    class Schelders
    {
        public void Schedulee()
        {
            string[] AllSchedule = { "Monday 8:30 - Poety", "Thusday 8:30 - History" };
            string[] UpdateSchedule = new string[AllSchedule.Length + 1];
            AllSchedule.CopyTo(UpdateSchedule, 0);
            UpdateSchedule[UpdateSchedule.Length - 1] = Day+" "+ time+" "+ lesson;

            for (int i = 0; i < UpdateSchedule.Length; i++)
            {
                Console.WriteLine(UpdateSchedule[i]);
            }

        }

        private string day;
        public string Day
        {
            get { return day; }
            set { day = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        private string lesson;
        public string Lesson
        {
            get { return lesson; }
            set { lesson = value; }
        }

    }
}
