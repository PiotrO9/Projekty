using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Models
{
    class MealToDisplay
    {
        public string Name { get; set; }
        public string Kcal { get; set; }
        public string Amount { get; set; }
        public string B { get; set; }
        public string T { get; set; }
        public string W { get; set; }

        public Command command { get; set; }
    }
}
