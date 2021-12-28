using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_07
{
    internal class EnrollCourse
    {
        public List<string> coursenamelist = new List<string>();
        public string Stuname;
        public string courseName;
        public string enrollDate;

        public string getroll()
        {
            string set = courseName + "\n";
            return set;
        }
    }
}
