using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogBookTask
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            studentList.Add(new Student
            {
                Fullname = "Akifli Akif Ramil",
                Datetime = "04/08/2022"
            });

            studentList.Add(new Student
            {
                Fullname = "Suleymanov Ilkin Ilham",
                Datetime = "04/08/2022"
            });

            studentList.Add(new Student
            {
                Fullname = "Quliyev Kamran Elchin",
                Datetime = "03/08/2022"
            });

            int x = 5;
            int y = 0;
            foreach (Student student in studentList)
            {
                StudentDesign studentDesign = new StudentDesign();
                studentDesign.Location = new Point(x, y);
                y += studentDesign.Height;
                students_container.Controls.Add(studentDesign);
                studentDesign.Fullname = student.Fullname;
                studentDesign.Datetime = student.Datetime;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            lesson_namelbl.Text = richTextBox1.Text;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void main_teacher_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

        }

        private void replaced_teacher_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            lesson_namelbl.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lesson_namelbl.Text = String.Empty;
            richTextBox1.Visible = true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
    
            if(guna2RadioButton1.Checked == true)
            {
                foreach (var item in students_container.Controls)
                {
                    if(item is StudentDesign sd)
                    {
                        foreach (var item2 in sd.Controls)
                        {
                            if(item2 is RadioButton rb)
                            {
                                if(rb.Name == "greenbtn")
                                {
                                    rb.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
