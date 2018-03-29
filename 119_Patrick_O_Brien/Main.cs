using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _119_Patrick_O_Brien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
