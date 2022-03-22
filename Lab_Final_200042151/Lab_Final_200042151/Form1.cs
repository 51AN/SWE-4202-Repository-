using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Final_200042151
{
    public partial class Form1 : Form
    {
        List<studentClass> studentClasses = new List<studentClass>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\User\Downloads\SWE4201MarkSheet.csv"))//reading CSV files
            {
                //skipping the first 9 lines
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(',');//setting line splitter to ','

                    
                    studentClass student = new studentClass();
                    //assigning to student class variables
                    student.id = segments[0];
                    student.name = segments[1];
                    student.attendance = segments[2];
                    student.quiz1 = segments[3];
                    student.quiz2 = segments[4];
                    student.quiz3 = segments[5];
                    student.quiz4 = segments[6];
                    student.mid = segments[7];
                    student.final = segments[8];
                    student.viva = segments[9];

                    double attendance;
                    double quiz1;
                    double quiz2;
                    double quiz3;
                    double quiz4;
                    double mid;
                    double final;
                    double viva;

                    //checking if variable is null, if so then taking it as 0
                    if (student.attendance != "")
                    {
                        attendance = Convert.ToDouble(student.attendance);
                    }
                    else
                    {
                        attendance = 0;
                    }
                    if (student.quiz1 != "")
                    {
                        quiz1 = Convert.ToDouble(student.quiz1);
                    }
                    else
                    {
                        quiz1 = 0;
                    }
                    if (student.quiz2 != "")
                    {
                        quiz2 = Convert.ToDouble(student.quiz2);
                    }
                    else
                    {
                        quiz2 = 0;
                    }
                    if (student.quiz3 != "")
                    {
                        quiz3 = Convert.ToDouble(student.quiz3);
                    }
                    else
                    {
                        quiz3 = 0;
                    }
                    if (student.quiz4 != "")
                    {
                        quiz4 = Convert.ToDouble(student.quiz4);
                    }
                    else
                    {
                        quiz4 = 0;
                    }

                    if (student.mid != "")
                    {
                        mid = Convert.ToDouble(student.mid);
                    }
                    else
                    {
                        mid = 0;
                    }
                    if (student.final != "")
                    {
                        final = Convert.ToDouble(student.final);
                    }
                    else
                    {
                        final = 0;
                    }
                    if (student.viva != "")
                    {
                        viva = Convert.ToDouble(student.viva);
                    }
                    else
                    {
                        viva = 0;
                    }

                    double quizTotal;
                    double totalMarks;
                    double percentage;
                    string grade;
                    

                    //determining total quiz marks (best 3 out of 4)
                    if(quiz4 <= quiz1 && quiz4 <= quiz2 && quiz4 <= quiz3)
                    {
                        quizTotal = quiz1 + quiz2 + quiz3;
                    }
                    else if(quiz3 <= quiz1 && quiz3 <= quiz2 && quiz3 <= quiz4)
                    {
                        quizTotal = quiz1 + quiz2 + quiz4;
                    }
                    else if(quiz2 <= quiz1 && quiz2 <= quiz3 && quiz2 <= quiz4)
                    {
                        quizTotal = quiz1 + quiz4 + quiz3;
                    }
                    else
                    {
                        quizTotal = quiz4 + quiz2 + quiz3;
                    }


                    totalMarks = attendance + quizTotal + mid + final + viva;//determining total marks

                    percentage = (totalMarks / 300.0) * 100;//finding out percentage



                    //Assigning grade
                    if(percentage>=80 && percentage<=100)
                    {
                        grade = "A+";
                    }
                    else if(percentage>=75 && percentage<=79)
                    {
                        grade = "A";
                    }
                    else if(percentage>=70 && percentage<=74)
                    {
                        grade = "A-";
                    }
                    else if(percentage>=65 && percentage<=69)
                    {
                        grade = "B+";
                    }
                    else if(percentage>=60 && percentage<=64)
                    {
                        grade = "B";
                    }
                    else if(percentage>=55 && percentage<=59)
                    {
                        grade = "B-";
                    }
                    else if(percentage>=50 && percentage<=54)
                    {
                        grade = "C+";
                    }
                    else if(percentage>=45 && percentage<=49)
                    {
                        grade = "C";
                    }
                    else if(percentage>=40 && percentage<=44)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }



                    student.total = Convert.ToString(totalMarks);
                    student.grade = grade;
                    percentage = Math.Round(percentage, 2);//rounding percentage (2 numbers from decimal point)
                    student.percentage = Convert.ToString(percentage);
                    student.quizTotal = Convert.ToString(quizTotal);
                    

                    studentClasses.Add(student);//assigning student to studentClass list
                }
            }
            //showing student result info in listbox
            for(int i=0;i<studentClasses.Count;i++)
            {
                listBox1.Items.Add("Student ID : " + studentClasses[i].printid());;
                listBox1.Items.Add("Student Name : " + studentClasses[i].printname());
                listBox1.Items.Add("Percentage : " + studentClasses[i].printPercent() + "%");
                listBox1.Items.Add("Grade : " +studentClasses[i].printGrade());
                listBox1.Items.Add("");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void searchByID(object sender, EventArgs e)
        {
            string checkID = studentIdBox.Text;
            bool errorExists = true;


            //using LINQ to search for student
            var student = from std in studentClasses
                          where std.id == checkID
                          select std;

            foreach(var std in student)
            {
                //if student found, then updating information
                attLabel.Text = "Attendance : " + std.attendance.ToString();
                quiz1label.Text = "Quiz 1 : " + std.quiz1.ToString();
                quiz2label.Text = "Quiz 2 : " + std.quiz2.ToString();
                quiz3label.Text = "Quiz 3 : " + std.quiz3.ToString();
                quiz4label.Text = "Quiz 4 : " + std.quiz4.ToString();
                quizTotal.Text = "Quiz Total (Best 3) : " + std.quizTotal.ToString();
                midLabel.Text = "Mid : " + std.mid.ToString();
                finalLabel.Text = "final : " + std.final.ToString();
                vivaLabel.Text = "Viva : " + std.viva.ToString();
                TotalLabel.Text = "Total (Out of 300) : " + std.total.ToString();
                percentLabel.Text = "Percentage : " + std.percentage.ToString() + " %";
                gradeLabel.Text = "Grade : " + std.grade;
                errorExists = false;
            }
            if(errorExists)
            {
                MessageBox.Show("Student doesn't exist in the database!");
            }

        }
    }
}
