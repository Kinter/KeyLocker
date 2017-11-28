using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyLocker
{
    public partial class Settings : Form
    {
        public int locktime = 0;
        Hook hook;
        public Settings()
        {
            hook = new Hook(this);
            InitializeComponent();
            Hook.timer1.Interval = 10000;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            this.ShowInTaskbar = false;

            Hook.timer1.Start();
            hook.ShowDialog(this);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000 < 10) numericUpDown3.Value = 10000;
            Hook.timer1.Interval = (int)((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000 < 10) numericUpDown3.Value = 10000;
            Hook.timer1.Interval = (int)((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000 < 10) numericUpDown3.Value = 10000;
            Hook.timer1.Interval = (int)((numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value)*1000);
        }
    }
}
