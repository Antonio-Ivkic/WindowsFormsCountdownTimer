using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCountdownTimer
{
    public partial class Timer : Form
    {
        private int Cooldown;

        public Timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Numerics
        private void numericSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numericSeconds?.Value != null)
                Seconds.Text = numericSeconds.Value.ToString();
        }

        private void numericMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (numericMinutes?.Value != null)
                Minutes.Text = numericMinutes.Value.ToString();
        }

        private void numericHours_ValueChanged(object sender, EventArgs e)
        {
            if (numericHours?.Value != null)
                Hours.Text = numericHours.Value.ToString();
        }
        #endregion
    }
}
