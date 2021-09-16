using Dziennik_treningowy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models.ExercisesModels
{
   public  class NoWeightExercise : IExercise, ICountable, ITimeable
    {
        public string Name { get ; set ; }
        public int Time { get ; set ; }
        public int Reps { get ; set ; }
        public int Duration { get ; set; }
    }
}
