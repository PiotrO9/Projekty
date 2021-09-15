using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
    public class TimeExercise : IExercise, ITimeable
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // Nazwa ćwiczenia
        public int Time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // Ewentualna przerwa po ćwiczeniu
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //Czas trwania ćwiczenia
    }
}
