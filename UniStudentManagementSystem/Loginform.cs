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
    public partial class Loginform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=UniversityStudentManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtpassword.Text;

            conn.Open();

            try
            {
                string query = "select * from Login where Username=@UserName and Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    MessageBox.Show("Login succesfull", "Student management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm f2 = new MainForm();
                    f2.Show();
                }
                else
                {

                    MessageBox.Show("Invalid Login  Credentials", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Text = "";
                    txtpassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
