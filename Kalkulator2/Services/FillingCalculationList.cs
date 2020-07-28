using Kalkulator2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    internal class FillingCalculationList
    {
        private bool _lastMinus = false;

        private readonly List<Item> _calculactionNameList;
        public FillingCalculationList(List<Item> items)
        {
            this._calculactionNameList = items ?? throw new ArgumentNullException();
        }
        public void AddOperation(OperationType operationType)
        {

            var lastItem = this._calculactionNameList.LastOrDefault();

            if (lastItem == null)
            {
                if (operationType == OperationType.Minus)
                {
                    _lastMinus = true;
                }
                return;
            }

            if (lastItem.CalcItemType == ItemType.Operation)
            {
                if (operationType == OperationType.Minus)
                {
                    _lastMinus = true;
                }
                return;
            }

            _lastMinus = false;

            Item test = new Item(operationType);
            _calculactionNameList.Add(test);
        }

        public void AddNumber(int number)
        {
            if (_lastMinus == true)
            {
                number *= -1;
                _lastMinus = false;
            }

            var lastItem = this._calculactionNameList.LastOrDefault();

            if (lastItem != null && lastItem.CalcItemType == ItemType.Number)
            {
                this._calculactionNameList.Remove(lastItem);

                string temp;

                temp = lastItem.ToString() + number.ToString();

                Item matched = new Item(int.Parse(temp));
                _calculactionNameList.Add(matched);

                return;
            }

            Item test = new Item(number);
            _calculactionNameList.Add(test);
        }
        public void Clear()
        {
            this._calculactionNameList.Clear();
            _lastMinus = false;
        }

        public string GetUserTextBox()
        {
            if (_calculactionNameList.Count == 0)
            {

                return _lastMinus ? "-" : string.Empty;
            }

            string temp = string.Empty;
            foreach (var item in _calculactionNameList)
            {
                temp += item.ToString();
            }
            temp += _lastMinus ? "-" : string.Empty;
            return temp;
        }

        public bool IsCorrect()
        {
            if (_calculactionNameList.Count < 3)
                return false;

            Item firstElement = _calculactionNameList.FirstOrDefault();

            Item secoundElement = _calculactionNameList.LastOrDefault();

            return firstElement.CalcItemType == ItemType.Number
                && secoundElement.CalcItemType == ItemType.Number;
        }

    }
}
