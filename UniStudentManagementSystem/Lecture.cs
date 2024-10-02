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
    public partial class Lecture : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Lecture()
        {
            InitializeComponent();
            FillbranchID();
            FilldepartmentID();
        }

        private void Lecture_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Lecture";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTLectureList.DataSource = ds.Tables[0];
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
        private void FillbranchID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select branchID from Branch", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("branchID", typeof(string));
            dt.Load(rdr);
            cmbB_ID.ValueMember = "branchID";
            cmbB_ID.DataSource = dt;
            conn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query1 = "Insert into Lecture (lectureID,lectureName,email,departmentID,branchId)" + "values(@lectureID,@lectureName,@email,@departmentID,@branchId)";
            //string query2 = "INSERT INTO Lecture_Contact (lectureID, lContactNo) VALUES (@lectureID, @lContactNo)";

            using (SqlCommand cmd1 = new SqlCommand(query1, conn))
            {
                cmd1.Parameters.AddWithValue("@lectureID", txtLectureID.Text);
                cmd1.Parameters.AddWithValue("@lectureName", txtLectureName.Text);
                cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd1.Parameters.AddWithValue("@departmentID", cmbDep_ID.Text);
                cmd1.Parameters.AddWithValue("@branchId", cmbB_ID.Text);

                int rowsAffected1 = cmd1.ExecuteNonQuery();
                if (rowsAffected1 > 0)

                            /*
                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                cmd2.Parameters.AddWithValue("@lectureID", txtLectureID);
                                cmd2.Parameters.AddWithValue("@lContactNo", txtL_Contact);

                                int rowsAffected2 = cmd2.ExecuteNonQuery();
                                if (rowsAffected2 > 0)
                                {
                                    MessageBox.Show("Successfully Added to both tables", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add to the second table, try again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to the first table, try again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
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

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update Lecture set lectureName='"+txtLectureName.Text+"',email='"+txtEmail.Text+"',departmentID='"+cmbDep_ID.Text+"',branchId='"+cmbB_ID.Text+"' where lectureID='" + txtLectureID.Text + "'";

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

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (txtLectureID.Text == "")
            {
                MessageBox.Show("Enter the  Lecture ID.");
            }
            else
            {


                String query = "delete  from Lecture where  lectureID='" + txtLectureID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete lecture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are your sure , Do you  really want to Back", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                this.Hide();
                MainForm f1 = new MainForm();
                f1.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are your sure , Do you  really want to Exit", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtLectureID.Text = "";
            txtLectureName.Text = "";
            txtEmail.Text = "";
            cmbB_ID.Text = "";
            cmbDep_ID.Text = "";
            txtLectureID.Focus();
        }

        private void DGTLectureList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtLectureID.Text = DGTLectureList.SelectedRows[0].Cells[0].Value.ToString();
            txtLectureName.Text = DGTLectureList.SelectedRows[0].Cells[1].Value.ToString();

            txtEmail.Text = DGTLectureList.SelectedRows[0].Cells[2].Value.ToString();
            cmbB_ID.Text = DGTLectureList.SelectedRows[0].Cells[3].Value.ToString();
            cmbDep_ID.Text = DGTLectureList.SelectedRows[0].Cells[4].Value.ToString();
           

        }
    }
}
