using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game.Engines
{
    public static class SetCorrectPath
    {
        public static string SetCorrectPathFunc(int i)
        {
            string temp = " ";

            switch (i)
            {
                case 1:
                    {
                        temp = "images/paper.PNG";
                        return temp;
                    }
                case 2:
                    {
                        temp = "images/Rock.PNG";
                        return temp;
                    }
                case 3:
                    {
                        temp = "images/Scissors.PNG";
                        return temp;
                    }
                case 4:
                    {
                        temp = "images/Cpaper.PNG";
                        return temp;
                    }
                case 5:
                    {
                        temp = "images/Crock.PNG";
                        return temp;
                    }
                case 6:
                    {
                        temp = "images/Cscissors.PNG";
                        return temp;
                    }
                default:
                    break;
            }

            return " ";
        }

    }
}
