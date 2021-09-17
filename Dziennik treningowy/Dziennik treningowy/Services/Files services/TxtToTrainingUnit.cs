using Dziennik_treningowy.Models;
using Dziennik_treningowy.Services.Setting_services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dziennik_treningowy.Services.Files_services
{
    public static class TxtToTrainingUnit
    {
        public static List<List<Exercise>> Method(string path)
        {
            List<List<Exercise>> ExercisesList = new List<List<Exercise>>(); // Zwracana lista

            string[] SingleListElements;

            using (var reader = new StreamReader(path))
            {
                SingleListElements = reader.ReadToEnd().Split('\n').Select(line => line.Trim()).ToArray();



                string temp = "";
                List<string> tempList = new List<string>();

                for (int i = 0; i < SingleListElements.Length; i++)
                {
                    if ((i + 1 < SingleListElements.Length))
                    {

                        if (SingleListElements[i] == "-")
                        {
                            tempList.Add(temp);
                            temp = string.Empty;
                        }
                        else if (SingleListElements[i] == "-###")
                        {
                            tempList.Add(temp);
                            temp = "#";
                            tempList.Add(temp);
                            temp = string.Empty;
                        }
                        else
                        {
                            temp += SingleListElements[i] + "\n";
                        }

                    }
                }

                ExercisesList = GetListOfListOfExercises.Method(tempList);

                return ExercisesList;

            }
        }
    }
}
