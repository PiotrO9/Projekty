using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_speed_test
{
    public partial class Form1 : Form
    {
        int typeOfTest = 1;
        int check = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Start")
            {
                typeOfTest = 1;
                btn1.Text = "0";
                timer1.Enabled = true;
            }
            else
            {
                int temp = int.Parse(btn1.Text);
                temp++;
                btn1.Text = temp.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "Start")
            {
                typeOfTest = 2;
                btn2.Text = "0";
                timer1.Enabled = true;
            }
            else
            {
                int temp = int.Parse(btn2.Text);
                temp++;
                btn2.Text = temp.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "Start")
            {
                typeOfTest = 3;
                btn3.Text = "0";
                timer1.Enabled = true;
            }
            else
            {
                int temp = int.Parse(btn3.Text);
                temp++;
                btn3.Text = temp.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "Start")
            {
                typeOfTest = 4;
                btn4.Text = "0";
                timer1.Enabled = true;
            }
            else
            {
                int temp = int.Parse(btn4.Text);
                temp++;
                btn4.Text = temp.ToString();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (typeOfTest)
            {
                case 1:
                    {
                        if (check < 10)
                        {
                            check++;
                            if (check > 9)
                            {
                                string temp = check.ToString();
                                label1.Text = check / 10 + "," + temp[temp.Length - 1];
                            }
                            else
                            {
                                label1.Text = 0 + "," + check.ToString();
                            }
                        }
                        else
                        {
                            float n = float.Parse(btn1.Text);

                            Form2 form2 = new Form2(1, n);
                            timer1.Enabled = false;

                            btn1.Text = "Start";
                            label1.Text = "0";
                            check = 0;
                            form2.Show();
                        }
                        break;
                    }
                case 2:
                    {
                        if (check < 50)
                        {
                            check++;
                            if (check > 9)
                            {
                                string temp = check.ToString();
                                label1.Text = check / 10 + "," + temp[temp.Length - 1];
                            }
                            else
                            {
                                label1.Text = 0 + "," + check.ToString();
                            }
                        }
                        else
                        {
                            float n = float.Parse(btn2.Text);

                            Form2 form2 = new Form2(5, n);
                            timer1.Enabled = false;
                            btn2.Text = "Start";
                            label1.Text = "0";
                            check = 0;
                            form2.Show();
                        }

                        break;
                    }
                case 3:
                    {
                        if (check < 100)
                        {
                            check++;
                            if (check > 9)
                            {
                                string temp = check.ToString();
                                label1.Text = check / 10 + "," + temp[temp.Length - 1];
                            }
                            else
                            {
                                label1.Text = 0 + "," + check.ToString();
                            }
                        }
                        else
                        {
                            float n = float.Parse(btn3.Text);

                            Form2 form2 = new Form2(10, n);
                            timer1.Enabled = false;
                            btn3.Text = "Start";
                            label1.Text = "0";
                            check = 0;
                            form2.Show();
                        }

                        break;
                    }
                case 4:
                    {
                        if (check < 6000)
                        {
                            check++;
                            if (check > 9)
                            {
                                string temp = check.ToString();
                                label1.Text = check / 10 + "," + temp[temp.Length - 1];
                            }
                            else
                            {
                                label1.Text = 0 + "," + check.ToString();
                            }
                        }
                        else
                        {
                            float n = float.Parse(btn4.Text);

                            Form2 form2 = new Form2(60, n);
                            timer1.Enabled = false;
                            btn4.Text = "Start";
                            label1.Text = "0";
                            check = 0;
                            form2.Show();
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }


    }
}
