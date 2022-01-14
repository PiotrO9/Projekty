using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class StringToMealsList
    {
        public static List<ObservableCollection<MealToDisplay>> StringToMealsListMethod(string ContentToConvert)
        {
            List<ObservableCollection<MealToDisplay>> result = new List<ObservableCollection<MealToDisplay>>();

            string[] array = ContentToConvert.Split('\n');

            ObservableCollection<MealToDisplay> currentCollection = new ObservableCollection<MealToDisplay>();

            int iterator = 1;

            MealToDisplay TempmealToDisplay = new MealToDisplay();

            foreach (var lane in array)
            {
                if (lane.Contains("###"))
                {
                    return result;
                }
                else if(lane.Contains("!!!"))
                {
                    result.Add(currentCollection);
                    currentCollection = new ObservableCollection<MealToDisplay>();
                    TempmealToDisplay = new MealToDisplay();
                    iterator = 1;
                }
                else if(lane.Contains("///"))
                {
                    TempmealToDisplay = new MealToDisplay();
                    iterator = 1;
                }
                else
                {
                    switch (iterator)
                    {
                        case 1:
                            {
                                TempmealToDisplay = new MealToDisplay();
                                TempmealToDisplay.Name = lane;
                                iterator++;
                                break;
                            }
                        case 2:
                            {
                                TempmealToDisplay.Amount = lane;
                                iterator++;
                                break;
                            }
                        case 3:
                            {
                                TempmealToDisplay.B = lane;
                                iterator++;
                                break;
                            }
                        case 4:
                            {
                                TempmealToDisplay.T = lane;
                                iterator++;
                                break;
                            }
                        case 5:
                            {
                                TempmealToDisplay.W = lane;
                                iterator++;
                                break;
                            }
                        case 6:
                            {
                                TempmealToDisplay.Kcal = lane;
                                iterator++;
                                break;
                            }
                        case 7:
                            {
                                TempmealToDisplay.ButtonName = lane;
                                iterator = 1;
                                currentCollection.Add(TempmealToDisplay);
                                break;
                            }
                    }

                }
            }

            return result;
        }
    }
}
