using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_07
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        List<Professional> proList = new List<Professional>();
        List<Course> courseList = new List<Course>();
        List<EnrollCourse> enCourseList = new List<EnrollCourse>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddPartOnClick(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string regno = RegBox.Text;
            string contactinfo = ConInfoBox.Text;
            string email = Emailox.Text;

            bool checkifStudent = StudentradioButton1.Checked;
            bool chechifPro = ProradioButton2.Checked;

            bool checkifBegin = BegradioButton3.Checked;
            bool chechifInter = InterradioButton5.Checked;
            bool checkifAdvanced = AdvradioButton4.Checked;

            if (checkifStudent)
            {
                Student dummystu = new Student();

                dummystu.setterStu(name, checkifBegin, chechifInter, checkifAdvanced);
                studentList.Add(dummystu);
                MessageBox.Show("Student Has Been Added!");
                StudentSelectcomboBox.Items.Add(name);

            }
            if (chechifPro)
            {
                Professional dummypro = new Professional();

                dummypro.setterPro(name, checkifBegin, chechifInter, checkifAdvanced);
                proList.Add(dummypro);
                MessageBox.Show("Pro Has Been Added!");
                StudentSelectcomboBox.Items.Add(name);


            }
        }

        private void addCourseOnClick(object sender, EventArgs e)
        {
            string title = TitleBox.Text;
             double fee = Convert.ToDouble(CourseFeeBox.Text);

            Course dummycourse = new Course();

            dummycourse.title = title;
            dummycourse.fee = fee;
            dummycourse.beginer = radioButton4.Checked;
            dummycourse.intermediate = radioButton5.Checked;
            dummycourse.advanced= radioButton6.Checked;
            SelectCoursecomboBox3.Items.Add(title);
            courseList.Add(dummycourse);    
            MessageBox.Show("Course Has Been Added!");


        }

        private void showFeeOnClick(object sender, EventArgs e)
        {
            string partName = StudentSelectcomboBox.Text;
            string courseName = SelectCoursecomboBox3.Text;
            bool errorExists = true;
            EnrollCourse dummyEn = new EnrollCourse();
            for(int i=0;i<studentList.Count;i++)
            {
                if(studentList[i].name == partName)
                {

                    for (int j = 0; j < courseList.Count; j++)
                    {
                        if (courseList[j].checkifCourseExists(courseName))
                        {
                            courseFeeLabel.Text ="Course Fee :" + studentList[i].fee(courseList[j].fee);
                            errorExists = false;
                            break;
                        }
                    }
                    break;

                }

            }

            for(int i=0;i<proList.Count;i++)
            {
                if(proList[i].name == partName)
                {

                    for (int j = 0; i < courseList.Count; j++)
                    {
                        if (courseList[j].checkifCourseExists(courseName))
                        {
                            courseFeeLabel.Text = "Course Fee :" + proList[i].fee(courseList[j].fee);

                            errorExists = false;
                            break;
                        }
                    }
                    break;

                }

            }

            

            if(errorExists)
            {
                MessageBox.Show("Invalid Input!!!");
            }
            else
            {

                
            }

        }

        private void payAndEnrollOnClick(object sender, EventArgs e)
        {
            string partName = StudentSelectcomboBox.Text;
            string courseName = SelectCoursecomboBox3.Text;
            bool errorExists = true;
            EnrollCourse dummyEn = new EnrollCourse();
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].name == partName)
                {
                    dummyEn.Stuname = studentList[i].name;
                    SelectStuCombo.Items.Add(studentList[i].name);
                    
                    for (int j = 0; j < courseList.Count; j++)
                    {
                        if (courseList[j].checkifCourseExists(courseName) && ((courseList[j].beginer == studentList[i].beginer )|| (courseList[j].intermediate == studentList[i].intermideate) || (courseList[j].advanced == studentList[i].advanced)) )
                        {

                            dummyEn.courseName = courseName;
                            //
                            dummyEn.coursenamelist.Add(courseName);
                            enCourseList.Add(dummyEn);
                            errorExists = false;
                            break;
                        }
                    }
                    break;

                }

            }

            for (int i = 0; i < proList.Count; i++)
            {
                if (proList[i].name == partName)
                {
                    dummyEn.Stuname = proList[i].name;
                    SelectStuCombo.Items.Add(proList[i].name);
                    for (int j = 0; j < courseList.Count; j++)
                    {
                        if (courseList[j].checkifCourseExists(courseName) && ((courseList[j].beginer == studentList[i].beginer) || (courseList[j].intermediate == studentList[i].intermideate) || (courseList[j].advanced == studentList[i].advanced)))
                        {

                            dummyEn.courseName = courseName;
                            //
                            dummyEn.coursenamelist.Add(courseName);
                            enCourseList.Add( dummyEn);
                            errorExists = false;
                            break;
                        }
                    }
                    break;

                }

            }

           
            dummyEn.enrollDate = EnrollmentBOx.Text;
            if (errorExists)
            {
                MessageBox.Show("Invalid Input!!!");
            }
            else
            {
                MessageBox.Show("Enrolled!");
            }

        }

        private void showEnrolledOnClick(object sender, EventArgs e)
        {
            string stuname= SelectStuCombo.Text;
            EnrollCourse dummyen = new EnrollCourse();
           /* for(int i=0;i<enCourseList.Count;i++)
            {
                if(stuname == enCourseList[i].Stuname)
                {
                    listBox1.Items.Add(enCourseList[i].getroll());
                }
            }*/

            for(int i=0;i<enCourseList.Count;i++)
            {
                if(stuname == enCourseList[i].Stuname)
                {
                    for(int j=0;j<enCourseList[i].coursenamelist.Count;j++)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(enCourseList[i].coursenamelist[j]);
                    }
                }
            }
        }
    }
}
