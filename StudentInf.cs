using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    class StudentInf
    {
        public string name;
        public string StudentInformation()
        {
            Console.WriteLine("Tell your name");
            name = Console.ReadLine();
            return name;
        } 
    }
}

