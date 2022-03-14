using Nutrition_App.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services
{
    public static class GetListOfWaterAmount
    {
        public static ObservableCollection<string> GetListOfWaterAmountMethod(WaterOperationType waterOperationType, int loops)
        {
            ObservableCollection<string> result = new ObservableCollection<string>();

            int StartingValue;
            int insideLoops = 0;

            switch (waterOperationType)
            {
                case WaterOperationType.TotalAmount:
                    {
                        StartingValue = 1000;
                    break;
                    }
                case WaterOperationType.Capacity:
                    {
                        StartingValue = 50;
                    break;
                    }
                default:
                    {
                        StartingValue = 50;
                        break;
                    }
            }

            if (insideLoops >= loops)
                return result;

            for (int i = StartingValue; insideLoops < loops; i += 50)
            {
                result.Add(i.ToString());
                insideLoops++;
            }

            return result;
        }
    }
}
