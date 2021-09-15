using Dziennik_treningowy.Models.ExercisesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Models
{
    public class Exercise
    {
        public NoWeightExercise noWeightExercise { get; set; }

        public WeightExercise weightExercise { get; set; }

        public TimeExercise timeExercise { get; set; }
    }
}
