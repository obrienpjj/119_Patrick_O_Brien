using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _119_Patrick_O_Brien.Business;

namespace _119_Patrick_O_Brien
{
    public partial class ModifyStudent : Form
    {
        private DataSet ds;
        Student student = new Student();
        DataTable dt = new DataTable();

        public ModifyStudent()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("No student loaded or selected. Please enter a Student ID and try again. ");
            }
            else
            {
                
                dt = student.getStudent(txtStudentID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtStudentID.Text = dt.Rows[0]["Student Number"].ToString();
                    txtFirst.Text = dt.Rows[0]["First Name"].ToString();
                    txtLast.Text = dt.Rows[0]["Last Name"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtAddress1.Text = dt.Rows[0]["Address Line 1"].ToString();
                    txtAddress2.Text = dt.Rows[0]["Address Line 2"].ToString();
                    txtCity.Text = dt.Rows[0]["City"].ToString();
                    comboCounty.Text = dt.Rows[0]["County"].ToString();
                    if ((dt.Rows[0]["Level"].ToString()) == "Postgraduate")
                    {
                        radioPost.Select();
                    }
                    else 
                    {
                        radioUnder.Select();
                    }
                    comboCourse.DataSource = 
                    comboCourse.DisplayMember = dt.Rows[0]["Course"].ToString();
                    comboCourse.BindingContext = this.BindingContext;
                }
                else
                {
                    throw new Exception();
                }
                //string expr = string.Format("[Student Number]={0}", txtStudentID.Text);
                //DataRow[] r = dt.Select(expr);
                //txtStudentID.Text = (string)r[0]["Student ID"];
                //txtFirst.Text = (string)r[0]["First Name"];
                //txtLast.Text = (string)r[0]["Last Name"];
                //txtEmail.Text = (string)r[0]["Email"];
                //txtPhone.Text = (string)r[0]["Phone"];
                //txtAddress1.Text = (string)r[0]["Address Line 1"];
                //txtAddress2.Text = (string)r[0]["Address Line 2"];
            }
        }

        private void comboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("No student loaded or selected. Please enter a Student ID and try again. ");
            }
            else
            {
                Student.deleteStudent(txtStudentID.Text);
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("No student loaded or selected. Please enter a Student ID and try again. ");
            }
            else if (txtXML.Text == "")
            {
                MessageBox.Show("No XML filename entered. Please enter a filename and try again. ");
            }
            else
            {
                dt.WriteXml(txtXML.Text);
                MessageBox.Show("Student successsfully written to XML file");
            }
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
