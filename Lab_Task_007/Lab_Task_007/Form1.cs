using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Task_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddPartOnClick(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string regno = RegBox.Text;
            string contact = ConInfoBox.Text;
            string email = Emailox.Text;

            string level;

            bool errorExists = false;
            if(BegradioButton1.Checked)
            {
                level = BegradioButton1.Text;
            }
            else if(InterradioButton1.Checked)
            {
                level=InterradioButton1.Text;
            }
            else
            {
                level = AdvradioButton1.Text;
            }

            if (StudentradioButton1.Checked)
            {

                for(int i=0;i<StudentClass.StudentList.Count;i++)
                {
                    if(StudentClass.StudentList[i].checkIfPartExists(name))
                    {
                        errorExists = true;
                        break;
                    }
                }
                if(errorExists)
                {
                    MessageBox.Show("Student Already Exists!");
                }
                else
                {
                    StudentClass dumbStudent = new StudentClass(name, regno,contact,email,level);
                    StudentClass.StudentList.Add(dumbStudent);
                    StudentSelectcomboBox.Items.Add(name);
                    SelectStuCombo.Items.Add(name);
                    MessageBox.Show("Student has been added!!!");
                }

            }

            if (ProradioButton1.Checked)
            {
                for (int i = 0; i < ProfessionalClass.ProList.Count; i++)
                {
                    if (ProfessionalClass.ProList[i].checkIfPartExists(name))
                    {
                        errorExists = true;
                        break;
                    }
                }
                if (errorExists)
                {
                    MessageBox.Show("Professional Already Exists!");
                }
                else
                {
                    ProfessionalClass dumbPro = new ProfessionalClass(name, regno, contact, email, level);
                    ProfessionalClass.ProList.Add(dumbPro);
                    StudentSelectcomboBox.Items.Add(name);
                    SelectStuCombo.Items.Add(name);
                    MessageBox.Show("Professional has been added!!!");
                }
            }

        }

        private void addCourseOnClick(object sender, EventArgs e)
        {
            string courseName = TitleBox.Text;
            string level;
            double coursefee = Convert.ToDouble(CourseFeeBox.Text);
            bool errorExists = false;
            if (BeginerRadioBox2.Checked)
            {
                level = BeginerRadioBox2.Text;
            }
            else if (IntermediateRadioBox2.Checked)
            {

                level=IntermediateRadioBox2.Text;
            }
            else
            {
                level = advancedRadinBox2.Text;
            }

            for(int i = 0;i < CourseClass.CourseList.Count; i++)
            {
                if(CourseClass.CourseList[i].checkIfCourseExist(courseName))
                {
                    errorExists=true;
                    break;
                }
            }

            if(errorExists)
            {
                MessageBox.Show("Course Already Exists!");
            }
            else
            {
                CourseClass dumbCourse = new CourseClass(courseName, level, coursefee);
                CourseClass.CourseList.Add(dumbCourse);
                SelectCoursecomboBox3.Items.Add(courseName);
                MessageBox.Show("Course Has Been Added!");

            }

        }

        private void EnrollOnClick(object sender, EventArgs e)
        {
            string partName = StudentSelectcomboBox.Text;
            string courseName = SelectCoursecomboBox3.Text;


            foreach(StudentClass student in StudentClass.StudentList)
            {
                if(partName == student.getName())
                {
                    foreach(CourseClass course in CourseClass.CourseList)
                    {
                        if (courseName == course.Name)
                        {
                            if (student.getLevel() == course.Level)
                            {
                                student.Enrolled_courses.Add(courseName);
                                courseFeeLabel.Text = "Course Fee : " + student.getFee(course.CourseFee).ToString();
                                
                                MessageBox.Show("Student Has Been Enrolled!");

                            }
                            else
                            {
                                MessageBox.Show("Levels Do Not Match!");
                            }
                        }
                    }
                    
                }
            }
            
            foreach(ProfessionalClass pro in ProfessionalClass.ProList)
            {
                if(partName == pro.getName())
                {
                    foreach(CourseClass course in CourseClass.CourseList)
                    {
                        if (courseName == course.Name)
                        {
                            if (pro.getLevel() == course.Level)
                            {
                                pro.Enrolled_courses.Add(courseName);
                                courseFeeLabel.Text = "Course Fee : " + pro.getFee(course.CourseFee).ToString();
                                
                                MessageBox.Show("Pro Has Been Enrolled!");

                            }
                            else
                            {
                                MessageBox.Show("Levels Do Not Match!");
                            }
                        }
                    }
                    
                }
            }

            

            
        }

        private void shoEnOnClick(object sender, EventArgs e)
        {
            string name = SelectStuCombo.Text;

            foreach (ProfessionalClass pro in ProfessionalClass.ProList)
            {
                if(name == pro.getName())
                {
                    listBox1.Items.Clear();
                    for(int i =0;i< pro.Enrolled_courses.Count;i++)
                    {
                        listBox1.Items.Add(pro.getName() + "\t" + pro.getReg() + "\t" + pro.Enrolled_courses[i]);
                    }
                }
            }
            foreach (StudentClass stu in StudentClass.StudentList)
            {
                if(name == stu.getName())
                {
                    listBox1.Items.Clear();
                    for(int i =0;i< stu.Enrolled_courses.Count;i++)
                    {
                        listBox1.Items.Add(stu.getName() + "\t" + stu.getReg() + stu.Enrolled_courses[i]);
                    }
                }
            }

        }
    }
}
