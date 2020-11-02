using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_Game.Models
{
    class Roller
    {
        public Panel panel { get; set; }

        public int size { get; private set; }

        public int number { get; private set; }

        public int fromWhichColumn { get; set; }

        public Roller(int s)
        {
            size = s;
            number = s;

            this.panel = new Panel();

            if (fromWhichColumn == 1)
            {
                this.panel.Visible = true;
                this.panel.Enabled = true;

                switch (s)
                {
                    case 1:
                        {
                            this.panel.Left = 55;
                            this.panel.Top = 200;
                            this.panel.Width = 90;
                            this.panel.Height = 10;
                            break;
                        }
                    case 2:
                        {
                            this.panel.Left = 60;
                            this.panel.Top = 220;
                            this.panel.Width = 80;
                            this.panel.Height = 10;
                            break;
                        }
                    case 3:
                        {
                            this.panel.Left = 65;
                            this.panel.Top = 240;
                            this.panel.Width = 70;
                            this.panel.Height = 10;
                            break;
                        }
                    case 4:
                        {
                            this.panel.Left = 70;
                            this.panel.Width = 60;
                            this.panel.Height = 10;
                            break;
                        }
                    case 5:
                        {
                            this.panel.Left = 75;
                            this.panel.Width = 50;
                            this.panel.Height = 10;
                            break;
                        }
                    case 6:
                        {
                            this.panel.Left = 80;
                            this.panel.Width = 40;
                            this.panel.Height = 10;
                            break;
                        }
                    case 7:
                        {
                            this.panel.Left = 85;
                            this.panel.Width = 30;
                            this.panel.Height = 10;
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (fromWhichColumn == 2)
            {

            }
            else if (fromWhichColumn == 3)
            {

            }
        }
    }
}
