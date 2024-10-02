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
    public partial class Department : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Department()
        {
            InitializeComponent();
            FillbranchID();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Department";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTDepartmentList.DataSource = ds.Tables[0];
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
            cmbBr_ID.ValueMember = "branchID";
            cmbBr_ID.DataSource = dt;
            conn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "Insert into Department (departmentID,departmentName,branchID)" + "values(@departmentID,@departmentName,@branchID)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text);
                cmd.Parameters.AddWithValue("@departmentName", txtDep_Name.Text);
                cmd.Parameters.AddWithValue("@branchID", cmbBr_ID.Text);




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

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update Department set  departmentName='" + txtDep_Name.Text + "',branchID='" + cmbBr_ID.Text + "' where departmentID='" + txtDepartmentID.Text + "'";

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
            if (txtDepartmentID.Text == "")
            {
                MessageBox.Show("Enter the  Department ID.");
            }
            else
            {


                String query = "delete  from Department where  departmentID='" + txtDepartmentID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtDepartmentID.Text = "";
            txtDep_Name.Text = "";
            cmbBr_ID.Text = "";
            txtDepartmentID.Focus();
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are your sure , Do you  really want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void DGTDepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtDepartmentID.Text = DGTDepartmentList.SelectedRows[0].Cells[0].Value.ToString();
            txtDep_Name.Text = DGTDepartmentList.SelectedRows[0].Cells[1].Value.ToString();
           cmbBr_ID.Text = DGTDepartmentList.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
