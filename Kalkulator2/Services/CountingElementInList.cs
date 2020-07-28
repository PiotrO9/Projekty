using Kalkulator2.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2.Services
{
    internal class CountingElementInList
    {
        public bool IsCalculatedOk { get; private set; }

        public string TextToDisplay { get; private set; }

        public int ResultCalculation { get; private set; }

        public CountingElementInList(List<Item> collectionToCalculate)
        {
            if (collectionToCalculate[1].CalcItemType == ItemType.Operation)
            {
                switch (collectionToCalculate[1].CalcOperationType)
                {
                    case OperationType.Plus:
                        {
                            string firstTempText = collectionToCalculate[0].ToString();
                            int firstTempNumber = int.Parse(firstTempText);

                            string secoundTempText = collectionToCalculate[2].ToString();
                            int secoundTempNumber = int.Parse(secoundTempText);

                            ResultCalculation = firstTempNumber + secoundTempNumber;
                            TextToDisplay = ResultCalculation.ToString();

                            if (ResultCalculation == (int)ResultCalculation)
                            {
                                IsCalculatedOk = true;

                                Item tempItem = new Item(ResultCalculation);

                                collectionToCalculate.Clear();
                                collectionToCalculate.Add(tempItem);
                            }

                            break;
                        }
                    case OperationType.Minus:
                        {
                            string firstTempText = collectionToCalculate[0].ToString();
                            int firstTempNumber = int.Parse(firstTempText);

                            string secoundTempText = collectionToCalculate[2].ToString();
                            int secoundTempNumber = int.Parse(secoundTempText);

                            ResultCalculation = firstTempNumber - secoundTempNumber;
                            TextToDisplay = ResultCalculation.ToString();

                            if (ResultCalculation == (int)ResultCalculation)
                            {
                                IsCalculatedOk = true;

                                Item tempItem = new Item(ResultCalculation);

                                collectionToCalculate.Clear();
                                collectionToCalculate.Add(tempItem);
                            }

                            break;
                        }
                    case OperationType.Multiplication:
                        {
                            string firstTempText = collectionToCalculate[0].ToString();
                            int firstTempNumber = int.Parse(firstTempText);

                            string secoundTempText = collectionToCalculate[2].ToString();
                            int secoundTempNumber = int.Parse(secoundTempText);

                            ResultCalculation = firstTempNumber * secoundTempNumber;
                            TextToDisplay = ResultCalculation.ToString();

                            if (ResultCalculation == (int)ResultCalculation)
                            {
                                IsCalculatedOk = true;

                                Item tempItem = new Item(ResultCalculation);

                                collectionToCalculate.Clear();
                                collectionToCalculate.Add(tempItem);
                            }

                            break;
                        }
                    case OperationType.Divide:
                        {
                            string firstTempText = collectionToCalculate[0].ToString();
                            int firstTempNumber = int.Parse(firstTempText);

                            string secoundTempText = collectionToCalculate[2].ToString();
                            int secoundTempNumber = int.Parse(secoundTempText);

                            if (secoundTempNumber == 0)
                            {
                                IsCalculatedOk = true;
                                MessageBox.Show("Dzielenie przez 0 niemożliwe");
                                collectionToCalculate.Clear();
                                TextToDisplay = string.Empty;
                                break;
                            }

                            ResultCalculation = firstTempNumber / secoundTempNumber;
                            TextToDisplay = ResultCalculation.ToString();

                            if (ResultCalculation == (int)ResultCalculation)
                            {
                                IsCalculatedOk = true;

                                Item tempItem = new Item(ResultCalculation);

                                collectionToCalculate.Clear();
                                collectionToCalculate.Add(tempItem);
                            }

                            break;
                        }
                }
            }




        }

    }
}
