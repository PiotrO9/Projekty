using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        List<string> listOfMeasures = new List<string>();

        bool active = false;


        int timeSec = 0;
        int timeMin = 0;
        int timeHours = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHM.Text = DateTime.Now.ToString("HH:mm");
            lblS.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDayName.Text = DateTime.Now.ToString("dddd");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (active == true)
            {
                timeSec++;

                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                    {
                        if (timeMin == 60)
                        {
                            timeHours++;
                            timeMin = 0;
                            if (timeHours >= 24)
                            {
                                ClearLabels();
                            }
                        }
                    }
                }
            }

            lblStoperTime.Text = setTimeInLabel();

        }

        private void btnStartOrStop_Click(object sender, EventArgs e)
        {
            if (active == false)
            {
                active = true;
                btnStartOrStop.Text = "Stop";
            }
            else
            {
                active = false;
                btnStartOrStop.Text = "Start";
            }
        }

        private string setTimeInLabel()
        {
            string tempSec;
            string tempMin;
            string tempH;

            if (timeSec < 10)
            {
                tempSec = "0" + timeSec.ToString();
            }
            else
            {
                tempSec = timeSec.ToString();
            }

            if (timeMin < 10)
            {
                tempMin = "0" + timeMin.ToString();
            }
            else
            {
                tempMin = timeMin.ToString();
            }

            if (timeHours < 10)
            {
                tempH = "0" + timeHours.ToString();
            }
            else
            {
                tempH = timeHours.ToString();
            }

            return tempH + ":" + tempMin + ":" + tempSec;

        }

        private void ClearLabels()
        {
            timeSec = 0;
            timeMin = 0;
            timeHours = 0;

            lblStoperTime.Text = setTimeInLabel();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ClearLabels();
            lstOfMesurement.Items.Clear();

            if (active == true)
            {
                active = false;
                btnStartOrStop.Text = "Start";
            }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            if (timeSec == 0 && timeMin == 0 && timeHours == 0)
            {
                return;
            }

            lstOfMesurement.Items.Add(setTimeInLabel());
        }

    }
}
