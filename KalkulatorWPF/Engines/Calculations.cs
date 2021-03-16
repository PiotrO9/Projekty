﻿using KalkulatorWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF.Engines
{
    public static class Calculations
    {
        public static Div0Model Calculate(string MainText)
        {
            char Action = ' ';

            int length = MainText.Length;
            int IndexOfAction = 0;

            float number1 = 0;
            float number2 = 0;

            if (MinusIncluded.CheckIfMinusIncluded(MainText) == false) // Bez minusa
            {
                for (int i = 0; i < length; i++)
                {
                    if (MainText[i] == '+' || MainText[i] == '*' || MainText[i] == '/')
                    {
                        Action = MainText[i];
                        IndexOfAction = i;
                        break;
                    }
                }

                string n1 = MainText.Remove(IndexOfAction);
                string n2 = MainText.Remove(0, IndexOfAction + 1);

                number1 = float.Parse(n1);
                number2 = float.Parse(n2);
            }
            else
            {
                int AmountOfMinuses = 0;
                List<int> NumbersOfIndexes = new List<int>();


                for (int i = 0; i < length; i++)
                {
                    if (MainText[i] == '-')
                    {
                        AmountOfMinuses++;
                        NumbersOfIndexes.Add(i);
                    }
                }

                if (AmountOfMinuses == 3)
                {
                    Action = '-';
                    IndexOfAction = NumbersOfIndexes[1];
                    string n1 = MainText.Remove(IndexOfAction);
                    string n2 = MainText.Remove(0, IndexOfAction + 1);

                    number1 = float.Parse(n1);
                    number2 = float.Parse(n2);
                }
                else if (AmountOfMinuses == 2)
                {
                    var IsActionModel = CheckIfAnyAction.CheckIfAnyActionExists(MainText);

                    if (IsActionModel.IsActionFound == true)
                    {

                    }
                }
                else
                {

                }
            }



            var ReturnModel = new Div0Model();

            switch (Action)
            {
                case '+':
                    {
                        ReturnModel.Result = number1 + number2;
                        ReturnModel.IsZero = false;
                        break;
                    }
                case '-':
                    {
                        ReturnModel.Result = number1 - number2;
                        ReturnModel.IsZero = false;
                        break;
                    }
                case '*':
                    {
                        ReturnModel.Result = number1 * number2;
                        ReturnModel.IsZero = false;
                        break;
                    }
                case '/':
                    {
                        if (number2 == 0)
                        {
                            ReturnModel.Result = 0;
                            ReturnModel.IsZero = true;
                        }
                        else
                        {
                            ReturnModel.Result = number1 / number2;
                            ReturnModel.IsZero = false;
                        }

                        break;
                    }
                default:
                    break;
            }

            return ReturnModel;
        }
    }
}
