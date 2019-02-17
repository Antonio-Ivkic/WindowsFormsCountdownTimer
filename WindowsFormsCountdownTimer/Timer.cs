using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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

        #region Buttons
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32((numericHours.Value * 3600) + (numericMinutes.Value * 60) + (numericSeconds.Value));
            Cooldown = count;

            CooldownTimer.Start();
            CooldownTimer.Enabled = true;

            

            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
            buttonStop.Enabled = true;
        }
        private void buttonPause_Click(object sender, EventArgs e)
        {
            PauseAction(buttonPause.Text);
        }
        private void PauseAction(string curtext)
        {
            if (curtext == "Pause")
            {
                CooldownTimer.Stop();
                CooldownTimer.Enabled = false;
                buttonPause.Text = "Resume";
            }
            else if (curtext == "Resume")
            {
                CooldownTimer.Start();
                CooldownTimer.Enabled = true;
                buttonPause.Text = "Pause";
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            CooldownTimer.Stop();
            CooldownTimer.Enabled = false;

            Cooldown = 0;
            

            buttonStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonStart.Enabled = false;

            if (buttonPause.Text == "Resume")
                buttonPause.Text = "Pause";
        }
        
        #endregion

    }
}
