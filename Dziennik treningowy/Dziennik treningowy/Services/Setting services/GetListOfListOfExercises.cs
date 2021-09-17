using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class GetListOfListOfExercises
    {
        public static List<List<Exercise>> Method(List<string> stringsList)
        {
            #region Initialization lists

            List<List<Exercise>> endingList = new List<List<Exercise>>();

            List<string[]> WorkingList = new List<string[]>();


            #endregion

            #region spliting string into string arrays

            for (int i = 0; i < stringsList.Count; i++)
            {
                WorkingList.Add(stringsList[i].Split('\n').Select(line => line.Trim()).ToArray() );
            }

            #endregion

            #region Setting first list

            int currentListNumber = 0;

            List<Exercise> tempList = new List<Exercise>();

            endingList.Add(tempList);

            #endregion

            #region Transforming all arrays and creating new list of exercises objects

            for (int i = 0; i < WorkingList.Count; i++)
            {
                if(stringsList[i] == "#")
                {
                    currentListNumber++;
                    List<Exercise> tmpList = new List<Exercise>();
                    endingList.Add(tmpList);
                }
                else
                {
                    Exercise exercise = StringArrayToExercise(WorkingList[i]);

                    endingList[currentListNumber].Add(exercise);
                }
            }

            #endregion

            return endingList; // Returning
        }

        #region Method to converting string array into Exercise object

        public static Exercise StringArrayToExercise(string[] array)
        {
            Exercise exercise = new Exercise();

            if(array.Length == 6)
            {
                WeightExercise weightExercise = new WeightExercise();
                weightExercise.Name = array[0];
                weightExercise.Time = int.Parse(array[1]);
                weightExercise.Weight = float.Parse(array[2]);
                weightExercise.Reps = int.Parse(array[3]);
                weightExercise.Duration = int.Parse(array[4]);

                exercise.weightExercise = weightExercise;

                return exercise;
            }
            else if(array.Length == 5)
            {
                NoWeightExercise noWeightExercise = new NoWeightExercise();
                noWeightExercise.Name = array[0];
                noWeightExercise.Time = int.Parse(array[1]);
                noWeightExercise.Reps = int.Parse(array[2]);
                noWeightExercise.Duration = int.Parse(array[3]);

                exercise.noWeightExercise = noWeightExercise;

                return exercise;
            }
            else if(array.Length == 4)
            {
                TimeExercise timeExercise = new TimeExercise();
                timeExercise.Name = array[0];
                timeExercise.Time = int.Parse(array[1]);
                timeExercise.Duration = int.Parse(array[2]);

                exercise.timeExercise = timeExercise;

                return exercise;
            }

            return exercise;
        }

        #endregion
    }
}
