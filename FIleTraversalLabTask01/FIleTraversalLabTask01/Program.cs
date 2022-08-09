using System;
using System.Collections.Generic;
using System.IO;

namespace FIleTraversalLabTask01
{
    internal class Program
    {


        public class student
        {
            public string ID;
            public string semester;
            public string GPA;
            
        }
        static void Main(string[] args)
        {
            List<student> studenList = new List<student>();
            using (var reader = new StreamReader(@"D:\SWE-20\CSE 4308 DBMS lab\Lab_Task_01\grades.txt"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(';');

                    student std = new student();

                    std.ID = segments[0];
                    std.GPA = segments[1];
                    std.semester = segments[2];
                    

                    studenList.Add(std);
                }
            }


            double maxGPA = 0;
            double maxindex = 0;

            

            for(int i = 0; i<studenList.Count; i++)
            {
                double tempGPA = Convert.ToDouble(studenList[i].GPA);
                if(tempGPA > maxGPA)
                {
                    maxGPA = tempGPA;
                    maxindex = i;

                }
            }

            Console.WriteLine(studenList[Convert.ToInt32(maxindex)].ID);
            Console.ReadKey();

        }
    }
}
