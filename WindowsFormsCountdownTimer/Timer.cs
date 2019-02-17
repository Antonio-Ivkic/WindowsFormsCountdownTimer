using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsCountdownTimer
{
    public partial class Timer : Form
    {
        private int Cooldown;

        public Timer()
        {
            InitializeComponent();
            updateTimerLabels();
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

            updateTimerLabels();

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
        #region Timer
        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            if(Cooldown > 0)
                Cooldown--;
            else
            {
                CooldownTimer.Stop();
                CooldownTimer.Enabled = false;

                buttonStart.Enabled = true;
                buttonPause.Enabled = false;
                buttonStop.Enabled = false;
            }
        }
        #endregion

        private void updateTimerLabels()
        {
            if (Cooldown > 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(Cooldown);
                string[] timeSplit = t.ToString().Split(':');
                Hours.Text = timeSplit[0];
                Minutes.Text = timeSplit[1];
                Seconds.Text = timeSplit[2];
            }
            else
            {
                if (numericSeconds?.Value !=null)
                    Seconds.Text = numericSeconds.Value.ToString();
                if (numericMinutes?.Value != null)
                    Minutes.Text = numericMinutes.Value.ToString();
                if (numericHours?.Value != null)
                    Hours.Text = numericHours.Value.ToString();
            }
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

    }
}
