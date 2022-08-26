using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    class Clas
    {
        private string newStudents;
        public string Newstudenst
        {
            get { return newStudents; }
            set { newStudents = value; }
        }
        public void Students()
        {
        string[] pupils = { "Adolf Mark", "Zina Kolo", };
        int L = pupils.Length;
            pupils[L + 1] = newStudents;

            foreach (var classmates in pupils)
            {
                Console.WriteLine(classmates);
            }
        }
}
