﻿using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingRoutinePage : ContentPage
    {
        public TrainingRoutinePage()
        {
            InitializeComponent();
            BindingContext = new TrainingRoutineViewModel();
        }
    }
}