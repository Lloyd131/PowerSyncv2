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
            led1.BackColor = Color.Lime;
            led2.BackColor = Color.Lime;
            led3.BackColor = Color.Lime;
            led4.BackColor = Color.Lime;
            led5.BackColor = Color.Lime;
            led6.BackColor = Color.Lime;
            fan1.BackColor = Color.Lime;
            fan2.BackColor = Color.Lime;
            fan3.BackColor = Color.Lime;
            fan4.BackColor = Color.Lime;
            fan5.BackColor = Color.Lime;
            fan6.BackColor = Color.Lime;
            BrkrStat.Text = "ACTIVE";
            BrkrStat.ForeColor = Color.Lime;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            indicator.BackColor = Color.Red;
            led1.BackColor = Color.Red;
            led2.BackColor = Color.Red;
            led3.BackColor = Color.Red;
            led4.BackColor = Color.Red;
            led5.BackColor = Color.Red;
            led6.BackColor = Color.Red;
            fan1.BackColor = Color.Red;
            fan2.BackColor = Color.Red;
            fan3.BackColor = Color.Red;
            fan4.BackColor = Color.Red;
            fan5.BackColor = Color.Red;
            fan6.BackColor = Color.Red;
            BrkrStat.Text = "INACTIVE";
            BrkrStat.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void floor1_Click(object sender, EventArgs e)
        {
            Brkr1.Visible = true;
            indicator.Visible = true;
            BrkrStat.Visible = true;
            ON.Visible = true;
            OFF.Visible = true;
        }

        private void Brkr1_Click(object sender, EventArgs e)
        {

        }
    }
}
