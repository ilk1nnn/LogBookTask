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
        StudentDesign studentDesign = new StudentDesign();

        public Form1()
        {
            InitializeComponent();

            students_container.Controls.Add(studentDesign);
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
