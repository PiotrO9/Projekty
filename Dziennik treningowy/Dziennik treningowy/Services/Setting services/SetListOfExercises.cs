using Dziennik_treningowy.Enums;
using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class SetListOfExercises // Tutaj dodawanie będą ćwiczenia, traktować to jako baza ćwiczeń 
    {
        public static Dictionary<string,TypeOfExercise> Method()
        {
            Dictionary<string, TypeOfExercise> dictionary = new Dictionary<string, TypeOfExercise>();
            dictionary.Add("Wyciskanie sztangi na ławce płaskiej",TypeOfExercise.Weight);
            dictionary.Add("Wyciskanie hantli na ławce płaskiej",TypeOfExercise.Weight);
            dictionary.Add("OHP",TypeOfExercise.Weight);
            dictionary.Add("Brzuszki",TypeOfExercise.NoWeight);
            dictionary.Add("Deska",TypeOfExercise.Time);
            dictionary.Add("Wznosy hantlami bokiem",TypeOfExercise.Weight);
            dictionary.Add("Wznosy hantlami przodem",TypeOfExercise.Weight);
            dictionary.Add("Wznosy sztangi przodem", TypeOfExercise.Weight);
            dictionary.Add("Pompki", TypeOfExercise.NoWeight);
            dictionary.Add("Pompki diamentowe", TypeOfExercise.NoWeight);
            dictionary.Add("Pompki na poręczach", TypeOfExercise.NoWeight);

            return dictionary;
        }

    }
}
