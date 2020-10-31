using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Game.Models
{
    class Roller
    {
        public int size { get; private set; }

        public int number { get; private set; }

        public int column { get; set; }

        public int width
        {
            get { return this.width; }

            set
            {
                if (column == 1)
                {
                    switch (size)
                    {
                        case 1:
                            {
                                this.width = 85;
                                break;
                            }
                        case 2:
                            {
                                this.width = 80;
                                break;
                            }
                        case 3:
                            {
                                this.width = 75;
                                break;
                            }
                        case 4:
                            {
                                this.width = 70;
                                break;
                            }
                        case 5:
                            {
                                this.width = 65;
                                break;
                            }
                        case 6:
                            {
                                this.width = 60;
                                break;
                            }
                        case 7:
                            {
                                this.width = 55;
                                break;
                            }

                        default:
                            break;
                    }
                }
            }
        }

        public int fromWhichColumn { get; set; }

        public Roller(int s)
        {
            size = s;
            number = s;
        }
    }
}
