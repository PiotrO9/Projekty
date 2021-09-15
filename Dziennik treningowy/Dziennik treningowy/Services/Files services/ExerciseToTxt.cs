using Dziennik_treningowy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dziennik_treningowy.Services.Files_services
{
    public static class ExerciseToTxt
    {
        public static void Method(Exercise exercise)
        {
            string temp = "";

            if(exercise.weightExercise != null)
            {
                var tempExercise = exercise.weightExercise;

                temp += tempExercise.Name + "\n";
                temp += tempExercise.Time + "\n";
                temp += tempExercise.Weight + "\n";
                temp += tempExercise.Reps + "\n";
                temp += tempExercise.Duration + "\n";

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

                path += "/test";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (var writer = new StreamWriter(File.Create(path + "/" + "file2.txt")))
                {
                    writer.Write(temp);
                }
                
            }
            else if(exercise.noWeightExercise != null)
            {

            }
            else
            {

            }
        }
    }
}
