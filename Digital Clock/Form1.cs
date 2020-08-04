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

        //Third part/////////////////////

        int sumOfTime = 0;

        int amountOfMinuts = 0;
        int amountOfSecounds = 0;


        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Sprawdzanie poprawności danych w textboxach
            if (txtM.Text == string.Empty)
            {
                if (txtS.Text == string.Empty)
                {
                    MessageBox.Show("Pola są puste");
                    return;
                }
                amountOfMinuts = 0;
            }
            else
            {
                if (int.TryParse(txtM.Text, out amountOfMinuts))
                {
                    amountOfMinuts = int.Parse(txtM.Text);
                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłową wartość");
                    return;
                }
            }



            if (txtS.Text == string.Empty)
            {
                if (txtM.Text == string.Empty)
                {
                    MessageBox.Show("Pola są puste");
                    return;
                }

                amountOfSecounds = 0;
            }
            else
            {
                if (int.TryParse(txtS.Text, out amountOfSecounds))
                {
                    amountOfSecounds = int.Parse(txtS.Text);
                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłową wartość");
                    return;
                }
            }

            btnAccept.Enabled = false;
            timer3.Enabled = true;
        }

        //Wyświetlanie czasu

        private string setTimeInTimer()
        {
            string tempM;
            string tempS;

            if (amountOfSecounds < 10)
            {
                tempS = "0" + amountOfSecounds.ToString();
            }
            else
            {
                tempS = amountOfSecounds.ToString();
            }

            //////////////////////////////

            if (amountOfMinuts < 10)
            {
                tempM = "0" + amountOfMinuts.ToString();
            }
            else
            {
                tempM = amountOfMinuts.ToString();
            }

            return tempM + ":" + tempS;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sumOfTime = amountOfMinuts * 60 + amountOfSecounds;

            lblTimer.Text = setTimeInTimer();
            if (sumOfTime > 0)
            {
                if (amountOfSecounds == 0)
                {
                    amountOfSecounds = 60;
                    amountOfMinuts--;
                }
                amountOfSecounds--;
            }
            else
            {
                txtS.Text = string.Empty;
                txtM.Text = string.Empty;
                btnAccept.Enabled = true;
                lblTimer.Text = "00:00";
                timer3.Enabled = false;
                MessageBox.Show("Czas upłynął");
                return;
            }
        }
    }
}
