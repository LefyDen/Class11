using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    class AboutTeacher
    {
        public void TeacherInfo()
        {
            string[] Teachers = { "Oksana Ivanivna", "Stepan Stetham - Science", "Taras olegovich" };
            foreach (var t in Teachers)
            {
                Console.WriteLine(t);
            }
        }
    }
}
