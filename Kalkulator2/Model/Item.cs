using EnumsNET;
using Kalkulator2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    public class Item
    {
        public ItemType CalcItemType { get; private set; }
        public OperationType? CalcOperationType { get; private set; }
        public double? CalcNumber { get; private set; }

        public Item(double number)
        {
            this.CalcNumber = number;
            this.CalcItemType = ItemType.Number;
        }

        public Item(OperationType operationType)
        {
            this.CalcOperationType = operationType;
            this.CalcItemType = ItemType.Operation;
        }

        public override string ToString() =>
            this.CalcItemType == ItemType.Number ? (CalcNumber ?? 0).ToString() :
                                                   (CalcOperationType ?? OperationType.Plus).AsString(EnumFormat.Description);
    }
}
