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
    public partial class Course : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");
        public Course()
        {
            InitializeComponent();
            FilldepartmentID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "Insert into Course (courseID,courseName,courseDescription,departmentID)" + "values(@courseID,@courseName,@courseDescription,@departmentID)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@courseID", txtCourseID.Text);
                cmd.Parameters.AddWithValue("@courseName", txtCourseName.Text);
                cmd.Parameters.AddWithValue("@courseDescription", txtC_des.Text);

                cmd.Parameters.AddWithValue("@departmentID", cmbDep_ID.Text);


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
        }

        private void Course_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Course";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTCourseList.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void FilldepartmentID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select departmentID from Department", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("departmentID", typeof(string));
            dt.Load(rdr);
            cmbDep_ID.ValueMember = "departmentID";
            cmbDep_ID.DataSource = dt;
            conn.Close();

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtC_des.Text = "";
            cmbDep_ID.Text = "";

            txtCourseID.Focus();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update Course set  courseName='" + txtCourseName.Text + "',courseDescription='" + txtC_des.Text + "',departmentID='" + cmbDep_ID.Text + "'where courseID='" + txtCourseID.Text + "'";

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

        private void txtCourseID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text == "")
            {
                MessageBox.Show("Enter the  ourse ID.");
            }
            else
            {


                String query = "delete  from Course where  courseID='" + txtCourseID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are your sure , Do you  really want to Exit", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure , Do you  really want to Back", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                this.Hide();
                MainForm f1 = new MainForm();
                f1.Show();
            }
        }

        private void DGTCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCourseID.Text = DGTCourseList.SelectedRows[0].Cells[0].Value.ToString();
            txtCourseName.Text = DGTCourseList.SelectedRows[0].Cells[1].Value.ToString();
            txtC_des.Text = DGTCourseList.SelectedRows[0].Cells[2].Value.ToString();
            //cmbDep_ID = DGTCourseList.SelectedRows[0].Cells[3].Value.ToString();
           
        }
    }
}
