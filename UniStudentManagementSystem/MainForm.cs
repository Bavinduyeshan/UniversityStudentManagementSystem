using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniStudentManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1= new Form1();
            f1.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course f2=new Course();
            f2.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department f3 = new Department();
            f3.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Branch f4 = new Branch();
            f4.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure , Do you  really want to Exit...", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                this.Hide();
                Application.Exit();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecture f5 = new Lecture();
            f5.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Module f6 = new Module();
            f6.Show();
        }
    }
}
