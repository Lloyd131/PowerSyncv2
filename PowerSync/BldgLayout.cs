using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSync
{
    public partial class BldgLayout : Form
    {
        public BldgLayout()
        {
            InitializeComponent();
        }

        private void ON_Click(object sender, EventArgs e)
        {
            indicator.BackColor = Color.Lime;
            Status.Text = "ACTIVE";
            Status.ForeColor = Color.Lime;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            indicator.BackColor = Color.Red;
            Status.Text = "INACTIVE";
            Status.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
