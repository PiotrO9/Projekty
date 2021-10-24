using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class SetExerciseType
    {
        public static TypeOfExercise Method(Exercise InputExercise)
        {
            TypeOfExercise typeOfExercise = new TypeOfExercise();

            if(InputExercise.weightExercise != null)
            {
                typeOfExercise = TypeOfExercise.Weight;
            }
            else if(InputExercise.noWeightExercise != null)
            {
                typeOfExercise = TypeOfExercise.NoWeight;
            }
            else
            {
                typeOfExercise = TypeOfExercise.Time;
            }

            return typeOfExercise;
        }
    }
}
