using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class TransformExerciseList
    {
        public static ObservableCollection<TransformedExercise> Method(List<Exercise> InputList)
        {
            ObservableCollection<TransformedExercise> result = new ObservableCollection<TransformedExercise>();

            foreach (var item in InputList)
            {
                TypeOfExercise typeOfExercise = SetExerciseType.Method(item);

                switch (typeOfExercise)
                {
                    case TypeOfExercise.Weight:
                        {
                            TransformedExercise transformedExercise = new TransformedExercise();
                            transformedExercise.Name = item.weightExercise.Name;
                            transformedExercise.Time = item.weightExercise.Time;
                            transformedExercise.Weight = item.weightExercise.Weight;
                            transformedExercise.Reps = item.weightExercise.Reps;
                            transformedExercise.Duration = item.weightExercise.Duration;

                            result.Add(transformedExercise);

                        break;
                        }
                    case TypeOfExercise.NoWeight:
                        {
                            TransformedExercise transformedExercise = new TransformedExercise();
                            transformedExercise.Name = item.noWeightExercise.Name;
                            transformedExercise.Time = item.noWeightExercise.Time;
                            transformedExercise.Reps = item.noWeightExercise.Reps;
                            transformedExercise.Duration = item.noWeightExercise.Duration;

                            result.Add(transformedExercise);

                            break;
                        }
                    case TypeOfExercise.Time:
                        {
                            TransformedExercise transformedExercise = new TransformedExercise();
                            transformedExercise.Name = item.timeExercise.Name;
                            transformedExercise.Time = item.timeExercise.Time;
                            transformedExercise.Duration = item.timeExercise.Duration;

                            result.Add(transformedExercise);

                            break;
                        }
                }

            }
                return result;
        }
    }
}
