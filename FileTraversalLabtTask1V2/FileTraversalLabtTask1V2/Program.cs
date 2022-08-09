using System;
using System.Collections.Generic;
using System.IO;

namespace FileTraversalLabtTask1V2
{
    internal class Program
    {


        public class student
        {

            public string ID;
            public string semester;
            public string GPA;
        }

        public class studentInfo
        {
            public string ID;
            public string name;
            public string age;
            public string bloodgroup;
            public string department;
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
            List<studentInfo> studenInfoList = new List<studentInfo>();
            using (var reader = new StreamReader(@"D:\SWE-20\CSE 4308 DBMS lab\Lab_Task_01\studentInfo.txt"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(';');

                    studentInfo stdin = new studentInfo();

                    stdin.ID = segments[0];
                    stdin.name = segments[1];
                    stdin.age = segments[2];
                    stdin.bloodgroup = segments[3];
                    stdin.department = segments[4];


                    studenInfoList.Add(stdin);
                }
            }

            Console.WriteLine("Enter student ID");
            string ID;
            ID = Console.ReadLine();
            Console.WriteLine("Enter student GPA");
            string GPA;
            GPA = Console.ReadLine();
            Console.WriteLine("Enter student Semester");
            string SEM;
            SEM = Console.ReadLine();

            bool errorExists = true;
            bool semRepeat = false;
            for(int i = 0; i<studenInfoList.Count; i++)
            {
                if(ID == studenInfoList[i].ID)
                {
                    errorExists = false;
                }
            }

            for(int i = 0; i<studenList.Count; i++)
            {
                if(ID == studenList[i].ID)
                {
                    if(studenList[i].semester == SEM)
                    {
                        semRepeat = true;
                    }
                }
            }


            double GPAcheck = Convert.ToDouble(GPA);
            if((GPAcheck >= 2.50) && (GPAcheck <= 4.0))
            {
                errorExists=false;
            }
            else
            {
                errorExists = true;
            }

            double SEMcheck = Convert.ToDouble(SEM);

            if((SEMcheck<=8)&&(SEMcheck>=1))
            {
                errorExists = false;
            }
            else
            {
                errorExists=(true); 
            }


            if (errorExists || semRepeat)
            {
                Console.WriteLine("Error in info");
                Console.ReadKey();
            }
            else
            {
                using (StreamWriter sw = File.AppendText(@"D:\SWE-20\CSE 4308 DBMS lab\Lab_Task_01\grades.txt"))
                {
                    sw.Write(ID + ';' + GPA + ';' + SEM + '\n');

                }

                Console.WriteLine("Complete!");
                Console.ReadKey();
            }

        }
    }
}
