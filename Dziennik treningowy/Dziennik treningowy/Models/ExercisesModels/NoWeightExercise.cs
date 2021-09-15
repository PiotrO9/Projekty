using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
   public  class NoWeightExercise : IExercise, ICountable, ITimeable
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Reps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
