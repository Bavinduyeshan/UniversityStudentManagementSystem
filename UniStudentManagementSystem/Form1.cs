using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniStudentManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
       


        public Form1()
        {
            InitializeComponent();
        }


       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGTStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = DGTStudentList.SelectedRows[0].Cells[0].Value.ToString();
            txtFName.Text = DGTStudentList.SelectedRows[0].Cells[1].Value.ToString();
            txtLName.Text = DGTStudentList.SelectedRows[0].Cells[2].Value.ToString();
            Dtp1.Text = DGTStudentList.SelectedRows[0].Cells[3].Value.ToString();
            cmbGender.Text = DGTStudentList.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress.Text = DGTStudentList.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = DGTStudentList.SelectedRows[0].Cells[6].Value.ToString();
            cmbCourseID.Text = DGTStudentList.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Student";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTStudentList.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           // if (txtStudentID.Text == "" || txtFName.Text == "" || txtLName.Text == "" || Dtp1.Text == "" || cmbGender.Text == "" || txtAddress.Text == "" || txtEmail.Text == "")
           // {
           //     MessageBox.Show("no empy fields accepted");
           // }
          //  else
            //{
                conn.Open();

                string query = "Insert into Student (studentID,firstName,lastname,DOB,gender,adddress,email,courseID)" + "values(@studentID,@firstName,@lastname,@DOB,@gender,@adddress,@email,@courseID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@firstName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLName.Text);

                    cmd.Parameters.AddWithValue("@DOB", Dtp1.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@adddress", txtAddress.Text);
                         cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@courseID", cmbCourseID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // txtTrainName.Focus();
                    }
                }
                conn.Close();
                Populate();
           // }
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update Student set  firstName='" + txtFName.Text +"',lastName='"+txtLName.Text+"',gender='"+cmbGender.Text+"',adddress='"+txtAddress.Text+"',email='"+txtEmail.Text+"',courseID='"+cmbCourseID.Text+"'where studentID='"+txtStudentID.Text+"'";

            SqlCommand cmd = new SqlCommand(query, conn);
            


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Succesfully Updated", "Hospiatl  Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Fail to uppdate ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            
            conn.Close();
            Populate();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            cmbCourseID.Text = "";
            txtStudentID.Focus();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Enter the  patient ID.");
            }
            else
            {


                String query = "delete  from Student where  studentID='" + txtStudentID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();

            }
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkOrange;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.NavajoWhite;
        }
    }
}
