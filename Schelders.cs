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
            int L = AllSchedule.Length;
            AllSchedule[L + 1] = Day+" "+time+" " +lesson;

            foreach (var Schedule in AllSchedule)
            {
                Console.WriteLine(classmates);
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
