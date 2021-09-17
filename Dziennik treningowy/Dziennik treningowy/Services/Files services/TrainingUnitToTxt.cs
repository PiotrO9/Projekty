using Dziennik_treningowy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dziennik_treningowy.Services.Files_services
{
    public static class TrainingUnitToTxt
    {
        public static void Method(List<List<Exercise>> TrainingUnit, string path)
        {
            string TextToFile = string.Empty; // główny string przesyłany do pliku txt

            #region Main loop converting all Exercise objects into string file

            foreach (var List in TrainingUnit)
            {
                foreach (var exercise in List)
                {
                    if(TextToFile == string.Empty)
                    {
                        TextToFile += ExerciseToTxt(exercise,true);
                    }
                    else
                    {
                        TextToFile += ExerciseToTxt(exercise, false);
                    }
                }

                
                TextToFile += "###";
            }

            #endregion

            #region Creating folder if does not exist

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            #endregion

            #region Saving into txt file at specific path

            using (var writer = new StreamWriter(File.Create(path + "/" + "save2.txt"))) // Tutaj dodać generowanie nazw plików
            {
                writer.Write(TextToFile);
            }

            #endregion

        }

        #region Converting exercise object to string, then concatenation into txt file

        private static string  ExerciseToTxt(Exercise exercise, bool IsFirst)
        {
            string temp = "";

            if (IsFirst == false)
            {
                temp += "\n";
            }

            if(exercise.weightExercise != null)
            {
                temp += exercise.weightExercise.Name + "\n";
                temp += exercise.weightExercise.Time + "\n";
                temp += exercise.weightExercise.Weight + "\n";
                temp += exercise.weightExercise.Reps + "\n";
                temp += exercise.weightExercise.Duration + "\n"; 
            }
            else if(exercise.noWeightExercise != null)
            {
                temp += exercise.noWeightExercise.Name + "\n";
                temp += exercise.noWeightExercise.Time + "\n";
                temp += exercise.noWeightExercise.Reps + "\n";
                temp += exercise.noWeightExercise.Duration + "\n";
            }
            else
            {
                temp += exercise.timeExercise.Name + "\n";
                temp += exercise.timeExercise.Time + "\n";
                temp += exercise.timeExercise.Duration + "\n";
            }

            temp += "-";

            return temp;
        }

        #endregion
    }
}


