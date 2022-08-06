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
    public partial class StudentDesign : UserControl
    {

        public string Fullname { get =>  fullnamelbl.Text;
             set => fullnamelbl.Text = value; }
        public string Datetime
        {
            get => date.Text
            ; set => date.Text = value;
        }
        public StudentDesign()
        {
            InitializeComponent();
        }

        private void crystal1_Click(object sender, EventArgs e)
        {
            crystal1.Image = Properties.Resources.diamond;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources.diamond;
            crystal1.Image = Properties.Resources.diamond;


        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = Properties.Resources.diamond;
            guna2PictureBox2.Image = Properties.Resources.diamond;
            crystal1.Image = Properties.Resources.diamond;

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            confirm.Visible = false;
            rejectbtn.Visible = false;
            feedbacktxtb.Visible = false;
            feddbacklbl.Text = feedbacktxtb.Text;

        }

        private void rejectbtn_Click(object sender, EventArgs e)
        {
            confirm.Visible = false;
            rejectbtn.Visible = false;
            feedbacktxtb.Visible = false;
            comment_img.Visible = true ;

            feddbacklbl.Text = String.Empty;


        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            confirm.Visible = true;
            rejectbtn.Visible = true;
            feedbacktxtb.Visible = true;
            comment_img.Visible = false ;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = Properties.Resources.diamond2;
            guna2PictureBox2.Image = Properties.Resources.diamond2;
            crystal1.Image = Properties.Resources.diamond2;
        }

        private void StudentDesign_Load(object sender, EventArgs e)
        {

        }
    }
}
