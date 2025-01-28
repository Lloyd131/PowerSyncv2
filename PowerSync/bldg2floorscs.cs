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
    public partial class bldg2floorscs : Form
    {
        public bldg2floorscs()
        {
            InitializeComponent();
        }

        private void ON_Click(object sender, EventArgs e)
        {

            BrkrStat.ForeColor = Color.Lime;
            BrkrStat.Text = "ACTIVE";
            indicator.BackColor = Color.Lime;

            Control[] devices = { led1, led2, led3, led4, led5, led6, led7, led8, led9, led10, led11, led12,
                      fan1, fan2, fan3, fan4, fan5, fan6, fan7, fan8, fan9, fan10, fan11, fan12 };


            foreach (Control device in devices)
            {
                device.BackColor = Color.Lime;
            }

        }

        private void floor1_Click(object sender, EventArgs e)
        {
            Brkr1.Visible = true;
            BrkrStat.Visible = true;
            ON.Visible = true;
            OFF.Visible = true;
            indicator.Visible = true;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            BrkrStat.ForeColor = Color.Red;
            BrkrStat.Text = "INACTIVE";
            indicator.BackColor = Color.Red;

            Control[] devices = { led1, led2, led3, led4, led5, led6, led7, led8, led9, led10, led11, led12,
                      fan1, fan2, fan3, fan4, fan5, fan6, fan7, fan8, fan9, fan10, fan11, fan12 };


            foreach (Control device in devices)
            {
                device.BackColor = Color.Red;
            }
        }

        private void floor2_Click(object sender, EventArgs e)
        {
            Brkr2.Visible = true;
            BrkrStat2.Visible = true;
            ON2.Visible = true;
            OFF2.Visible = true;
            indicator2.Visible = true;
        }

        private void ON2_Click(object sender, EventArgs e)
        {
            BrkrStat2.ForeColor = Color.Lime;
            BrkrStat2.Text = "ACTIVE";
            indicator2.BackColor = Color.Lime;

            Control[] devices = { led1b, led2b, led3b, led4b, led5b, led6b,
                                  fan1b, fan2b, fan3b, fan4b, fan5b, fan6b };


            foreach (Control device in devices)
            {
                device.BackColor = Color.Lime;
            }
        }

        private void OFF2_Click(object sender, EventArgs e)
        {
            BrkrStat2.ForeColor = Color.Red;
            BrkrStat2.Text = "INACTIVE";
            indicator2.BackColor = Color.Red;

            Control[] devices = { led1b, led2b, led3b, led4b, led5b, led6b,
                                  fan1b, fan2b, fan3b, fan4b, fan5b, fan6b };


            foreach (Control device in devices)
            {
                device.BackColor = Color.Red;
            }
        }
    }
}
