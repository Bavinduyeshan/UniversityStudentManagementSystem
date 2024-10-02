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
    public partial class Branch : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Branch()
        {
            InitializeComponent();
        }

        private void Branch_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {

            conn.Open();
            string query = "SELECT * FROM Branch";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTBranchList.DataSource = ds.Tables[0];
            conn.Close();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "Insert into Branch (branchID,branchName)" + "values(@branchID,@branchName)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@branchID", txtBranchID.Text);
                cmd.Parameters.AddWithValue("@branchName", txtBranchName.Text);
         


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

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtBranchID.Text = "";
            txtBranchName.Text = "";
            txtBranchID.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtBranchID.Text == "")
            {
                MessageBox.Show("Enter the  branch ID.");
            }
            else
            {


                String query = "delete  from Branch where  branchID='" + txtBranchID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    MessageBox.Show("record deleted succesfully.", "Delete branch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Populate();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are your sure , Do you  really want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
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

        private void DGTBranchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBranchID.Text = DGTBranchList.SelectedRows[0].Cells[0].Value.ToString();
            txtBranchName.Text = DGTBranchList.SelectedRows[0].Cells[1].Value.ToString();
           
        }
    }
}
