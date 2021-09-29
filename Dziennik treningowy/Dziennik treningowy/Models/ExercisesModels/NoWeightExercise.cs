using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
   public  class NoWeightExercise : IExercise, ICountable, ITimeable
    {
        public string Name { get ; set ; } // Nazwa ćwiczenia
        public int Time { get ; set ; } // Ewentualna przerwa po ćwiczeniu
        public int Reps { get ; set ; } // Powtórzenia w serii
        public int Duration { get ; set; } //Czas trwania ćwiczenia
    }
}
