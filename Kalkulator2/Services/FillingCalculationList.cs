using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    internal class FillingCalculationList
    {
        private readonly List<Item> _calculactionNameList;
        public FillingCalculationList(List<Item> items)
        {
            this._calculactionNameList = items ?? throw new ArgumentNullException();
        }
        public void AddOperation(OperationType operationType)
        {
            var lastItem = this._calculactionNameList.LastOrDefault();
        }

        public void AddNumber(double number)
        {

        }
        public void Clear()
        {
            this._calculactionNameList.Clear();
        }

        public string GetUserTextBox()
        {
            return string.Empty;
        }

    }
}
