using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_07
{
    internal class Course
    {
        public string title;
        public bool beginer;
        public bool intermediate;
        public bool advanced;

        public double fee;


        public bool checkifCourseExists(string check)
        {
            if(check == title)
            {
                return true;

            }
            else return false;
        }

    }
}
