using Kalkulator2.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2.Services
{
    internal class CountingElementInList
    {
        public bool IsCalculatedOk { get; private set; }

        public string TextToDisplay { get; private set; }

        public double ResultCalculation { get; private set; }

        public CountingElementInList(List<Item> collectionToCalculate)
        {
            if (collectionToCalculate[1].CalcItemType == ItemType.Operation)
            {
                switch (collectionToCalculate[1].CalcOperationType)
                {
                    case OperationType.Plus:
                        {
                            int firstTemp = collectionToCalculate[1].
                                break;
                        }
                }
            }




        }

    }
}
