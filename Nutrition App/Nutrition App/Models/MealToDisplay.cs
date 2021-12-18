using GalaSoft.MvvmLight.Command;
using Nutrition_App.Interfaces;
using Nutrition_App.Services.ConvertingServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Models
{
    class MealToDisplay 
    {

        public string Name { get; set; }
        public string ButtonName { get; set; } // Przyciski nazwywać według wzoru: btn_numer kolekcji_numer itmu w liście np. btn_1_5
        public string Kcal { get; set; }
        public string Amount { get; set; }
        public string B { get; set; }
        public string T { get; set; }
        public string W { get; set; }

        public Command command {get; set; }
    }
}
