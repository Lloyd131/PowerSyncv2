using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSync
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (username.Text == "admin" && password.Text == "admin123")
            {
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password incorrect");
                username.Clear();
                password.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}