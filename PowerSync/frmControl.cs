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
            ttbdo.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoader.Controls.Clear();
            BldgLayout BldgLayout_Vrb = new BldgLayout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BldgLayout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoader.Controls.Add(BldgLayout_Vrb);
            BldgLayout_Vrb.Show();

        }

        private void add_Click(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoader.Controls.Clear();
            newbldg newbldg_Vrb = new newbldg() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            newbldg_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoader.Controls.Add(newbldg_Vrb);
            newbldg_Vrb.Show();

        }

        private void ttbdo_Leave(object sender, EventArgs e)
        {
            ttbdo.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void add_Leave(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void bldgA_Click(object sender, EventArgs e)
        {
            bldgA.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoader.Controls.Clear();
            bldg2floorscs bldgA_Vrb = new bldg2floorscs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bldgA_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoader.Controls.Add(bldgA_Vrb);
            bldgA_Vrb.Show();
        }
    }
}
