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
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttbdo.BackColor = Color.FromArgb(211, 211, 211);

            this.bldglayoutFormLoader.Controls.Clear();
            BldgLayout BldgLayout_Vrb = new BldgLayout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BldgLayout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.bldglayoutFormLoader.Controls.Add(BldgLayout_Vrb);
            BldgLayout_Vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ttbdo_Leave(object sender, EventArgs e)
        {
            ttbdo.BackColor = Color.FromArgb(37, 42, 64);
        }
    }
}
