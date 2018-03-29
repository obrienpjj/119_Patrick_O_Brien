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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\obrie\Documents\College Stuff\B8IT119\Assignment\119_Patrick_O_Brien\119_Patrick_O_Brien\LocalDatabase.mdf'; Integrated Security = True");

            // string Query = "insert into Student (First Name, Last Name, Email, Phone, Address Line 1, Address Line 2, City, County, Level, Course, Student Number) values ('" + this.txtFirst.Text + "','" + this.txtLast.Text + "','" + this.txtEmail.Text + "','" + this.txtPhone.Text + "', '" + this.txtAddress1.Text + "', '" + this.txtAddress2.Text + "', '" + this.txtCity.Text + "','" + this.comboCounty.Text + "',@studentType,'" + this.comboCourse.Text + "','" + this.txtStudentID.Text + "');";
            // SqlCommand insertCommand = new SqlCommand();
            string radioText;
            if (radioUnder.Checked)
            {
                radioText = radioUnder.Text;
            }
            else
            {
                radioText = radioPost.Text;
            }

            Student.addStudent(txtFirst.Text, txtLast.Text, txtEmail.Text, txtPhone.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text, comboCounty.Text, radioText, comboCourse.Text, txtStudentID.Text);
            MessageBox.Show("Student entered");

            //insertCommand = new SqlCommand(Query, conn);
           // try
           // {
           //     conn.Open();
            //    SqlDataReader entryReader = insertCommand.ExecuteReader();
           //     MessageBox.Show("Student entry saved");
            //    while (entryReader.Read()) { }
           // }
            //catch(Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
           //     
            //}
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm ss = new LoginForm();
            this.Hide();
            ss.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            this.Hide();
            add.Show();
        }

        private void modifyStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyStudent mod = new ModifyStudent();
            this.Hide();
            mod.Show();
        }
    }
}
