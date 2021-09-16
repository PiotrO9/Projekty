using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
    public class TimeExercise : IExercise, ITimeable
    {
        public string Name { get ; set ; } // Nazwa ćwiczenia
        public int Time { get ; set ; } // Ewentualna przerwa po ćwiczeniu
        public int Duration { get ; set ; } //Czas trwania ćwiczenia
    }
}
