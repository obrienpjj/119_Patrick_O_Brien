using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _119_Patrick_O_Brien.Business;

namespace _119_Patrick_O_Brien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\obrie\Documents\College Stuff\B8IT119\Assignment\119_Patrick_O_Brien\119_Patrick_O_Brien\LocalDatabase.mdf'; Integrated Security = True");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE Username='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    this.Hide();

            //    Main ss = new Main();
            //    ss.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Username or password incorrect. Please check your details and try again.");
            //}



            Login login = new Login();
            if (login.CheckLogin(txtUserName.Text, txtPassword.Text) == true)
            { 
                this.Hide();

                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Please check your details and try again.");
                txtPassword.Text = "";
                txtUserName.Text = "";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
