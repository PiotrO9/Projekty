using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;

namespace Dziennik_treningowy.Models
{
    public class TransformedExercise : ObservableObject
    {

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private int _time;
        public int Time
        {
            get => _time;
            set => SetProperty(ref _time, value);
        }

        private float _weight;
        public float Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private int _reps;
        public int Reps
        {
            get => _reps;
            set => SetProperty(ref _reps, value);
        }

        private int _duration;
        public int Duration
        {
            get => _duration;
            set => SetProperty(ref _duration, value);
        }
    }
}
