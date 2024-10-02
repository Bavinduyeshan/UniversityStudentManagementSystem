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
    public partial class Module : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Module()
        {
            InitializeComponent();
            FillcourseID();
            FilllectureID();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Module";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTModuleList.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void FilllectureID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select lectureID from Lecture", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("lectureID", typeof(string));
            dt.Load(rdr);
            cmbLec_ID.ValueMember = "lectureID";
            cmbLec_ID.DataSource = dt;
            conn.Close();

        }
        private void FillcourseID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select courseID from Course", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("courseID", typeof(string));
            dt.Load(rdr);
            cmbC_ID.ValueMember = "courseID";
            cmbC_ID.DataSource = dt;
            conn.Close();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query1 = "Insert into Module (moduleID,moduleName,startDate,endDate,lectureID,courseID)" + "values(@moduleID,@moduleName,@startDate,@endDate,@lectureID,@courseID)";
            //string query2 = "INSERT INTO Lecture_Contact (lectureID, lContactNo) VALUES (@lectureID, @lContactNo)";

            using (SqlCommand cmd1 = new SqlCommand(query1, conn))
            {
                cmd1.Parameters.AddWithValue("@moduleID", txtModuleID.Text);
                cmd1.Parameters.AddWithValue("@moduleName", txtModuleName.Text);
                cmd1.Parameters.AddWithValue("@startDate", DTPSDate.Text);
                cmd1.Parameters.AddWithValue("@endDate", DTPEdate.Text);
                cmd1.Parameters.AddWithValue("@lectureID", cmbLec_ID.Text);
                cmd1.Parameters.AddWithValue("@courseID", cmbC_ID.Text);

                int rowsAffected1 = cmd1.ExecuteNonQuery();
                if (rowsAffected1 > 0)

                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtModuleID.Text == "")
            {
                MessageBox.Show("Enter the  Module ID.");
            }
            else
            {


                String query = "delete  from Module where  moduleID='" + txtModuleID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure , Do you  really want to Exit", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
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

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtModuleID.Text = "";
            txtModuleName.Text = "";
           
            cmbC_ID.Text = "";
            cmbLec_ID.Text = "";
            txtModuleID.Focus();
        }

        private void DGTModuleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtModuleID.Text = DGTModuleList.SelectedRows[0].Cells[0].Value.ToString();
            txtModuleName.Text = DGTModuleList.SelectedRows[0].Cells[1].Value.ToString();

            DTPSDate.Text = DGTModuleList.SelectedRows[0].Cells[2].Value.ToString();
            DTPEdate.Text = DGTModuleList.SelectedRows[0].Cells[3].Value.ToString();
            cmbC_ID.Text = DGTModuleList.SelectedRows[0].Cells[4].Value.ToString();
            cmbLec_ID.Text = DGTModuleList.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
    
}
