using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dziennik_treningowy.Services.Files_services
{
    public static class TxtToExercise
    {
        public static Exercise Method(string path)
        {
            string[] tempArray;

            int ArrayLength = 0;

            Exercise exercise = new Exercise();

            using(var reader = new StreamReader(path))
            {
                tempArray = reader.ReadToEnd().Split('\n').Select(line => line.Trim()).ToArray();
            }

            if(tempArray.Length - 1 == 5)
            {
                ArrayLength = 5;
            }
            else if(tempArray.Length - 1 == 4)
            {
                ArrayLength = 4;
            }
            else if (tempArray.Length - 1 == 3)
            {
                ArrayLength = 3;
            }

            switch (ArrayLength)
            {
                case 3:
                    {
                        exercise.timeExercise = new TimeExercise();
                        exercise.timeExercise.Name = tempArray[0];
                        exercise.timeExercise.Time = int.Parse(tempArray[1]);
                        exercise.timeExercise.Duration = int.Parse(tempArray[2]);

                        break;
                    }
                case 4:
                    {
                        exercise.noWeightExercise = new NoWeightExercise();
                        exercise.noWeightExercise.Name = tempArray[0];
                        exercise.noWeightExercise.Time = int.Parse(tempArray[1]);
                        exercise.noWeightExercise.Reps = int.Parse(tempArray[2]);
                        exercise.noWeightExercise.Duration = int.Parse(tempArray[3]);

                        break;
                    }
                case 5:
                    {
                        exercise.weightExercise = new WeightExercise();
                        exercise.weightExercise.Name = tempArray[0];
                        exercise.weightExercise.Time = int.Parse(tempArray[1]);
                        exercise.weightExercise.Weight = float.Parse(tempArray[2]);
                        exercise.weightExercise.Reps = int.Parse(tempArray[3]);
                        exercise.weightExercise.Duration = int.Parse(tempArray[4]);

                        break;
                    }
                default:
                    break;
            }

            return exercise;

        }
    }
}
