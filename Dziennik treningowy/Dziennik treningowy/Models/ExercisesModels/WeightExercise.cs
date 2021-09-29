using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
    public class WeightExercise : IExercise, IWeighable, ICountable,ITimeable
    {
        public string Name { get ; set; } // Nazwa ćwiczenia
        public int Time { get; set; } // Ewentualna przerwa po ćwiczeniu
        public float Weight { get; set; } // Ciężar używany w ćwiczeniu
        public int Reps { get; set; } // Powtórzenia w serii
        public int Duration { get; set; } //Czas trwania ćwiczenia
    }
}
