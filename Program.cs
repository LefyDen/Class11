using System;

namespace Home11
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInf newSoul = new StudentInf();
            Console.WriteLine("Hi" + newSoul.StudentInformation());

            Clas classmates = new Clas();
            classmates.Newstudenst = newSoul.name;
            Console.WriteLine("Your class:");
            classmates.Students();

            Schelders newTime = new Schelders();            
            newTime.Lesson = "Englisk";
            newTime.Day = "friday";
            newTime.Time = "9.00";
            Console.WriteLine("YourNew time Table");
            newTime.Schedulee();

            AboutTeacher about = new AboutTeacher();
            Console.WriteLine("Teachers info:");
            about.TeacherInfo();
            

        }

//too big whitespace

    }
}
//checked
