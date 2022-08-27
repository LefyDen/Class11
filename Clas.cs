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
            string[] pupils = { "Adolf Mark", "Zina Kolo","Zina Kolo", "Zina Kolo", "Zina Kolo", "Zina Kolo" };            
            string[] UpdatePupils = new string[pupils.Length+1];
            pupils.CopyTo(UpdatePupils, 0);
            UpdatePupils[UpdatePupils.Length-1] = newStudents;


            for (int i = 0; i < UpdatePupils.Length; i++)
            {
                Console.WriteLine(UpdatePupils[i]);
            }
        }
    }
}