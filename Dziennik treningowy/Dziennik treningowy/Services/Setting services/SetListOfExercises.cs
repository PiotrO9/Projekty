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

            //Klata

            dictionary.Add("Wyciskanie sztangi na ławce płaskiej",TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli na ławce płaskiej",TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli na ławce ujemnej",TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli na ławce dodatniej",TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli wąskim chwytem",TypeOfExercise.Weight); //Image
            dictionary.Add("Rozpiętki",TypeOfExercise.Weight); //Image
            dictionary.Add("Pompki", TypeOfExercise.NoWeight); //Image
            dictionary.Add("Pompki diamentowe", TypeOfExercise.NoWeight); //Image

            //Tric

            dictionary.Add("Pompki na poręczach (Dipy)", TypeOfExercise.NoWeight); //Image
            dictionary.Add("Pompki na poręczach z obciążeniem (Dipy)", TypeOfExercise.Weight); //Image
            dictionary.Add("Prostowanie ramion na wyciągu górnym", TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie francuskie sztangą łamaną (Skull crushery)", TypeOfExercise.Weight); //Image

            //Barki

            dictionary.Add("OHP",TypeOfExercise.Weight); // Image
            dictionary.Add("Wznosy hantlami bokiem",TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli nad głowę", TypeOfExercise.Weight); //Image
            dictionary.Add("Wyciskanie hantli nad głowę (Arnold press)", TypeOfExercise.Weight); //Image
            dictionary.Add("Wznosy hantli bokiem w opadzie", TypeOfExercise.Weight); //Image

            //Bic

            dictionary.Add("Uginanie ramion z hantlami z suplinacją stojąc",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramion z hantlami z suplinacją siedząc",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramion z hantlami chwytem młotkowym",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramienia z hantlą na ławce",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramienia z hantlą na kolanie",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramion ze sztangą prostą",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramion ze sztangą łamaną",TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie ramion ze sztangą na modlitweniku",TypeOfExercise.Weight); //Image

            //Przedramie

            dictionary.Add("Uginanie ramion ze sztangą łamaną chwytem odwrotnym", TypeOfExercise.NoWeight); //Image

            //Plecy

            dictionary.Add("Podciąganie nadchwytem" , TypeOfExercise.NoWeight); //Image
            dictionary.Add("Podciąganie podchwytem" , TypeOfExercise.NoWeight); //Image
            dictionary.Add("Podciąganie z obciążeniem" , TypeOfExercise.Weight); //Image
            dictionary.Add("Wiosłowanie (T-row)" , TypeOfExercise.Weight); //Image
            dictionary.Add("Wiosłowanie sztangą" , TypeOfExercise.Weight); //Image
            dictionary.Add("Narciarz" , TypeOfExercise.Weight); //Image
            dictionary.Add("Ściąganie wyciągu górnego szeroko" , TypeOfExercise.Weight); //Image
            dictionary.Add("Ściąganie wyciągu górnego wąsko" , TypeOfExercise.Weight); //Image
            dictionary.Add("Wiosłowanie hantlą w opadzie" , TypeOfExercise.Weight); //Image
            dictionary.Add("Prostowanie na modlitewniku" , TypeOfExercise.Weight); //Image

            //Nogi

            dictionary.Add("Martwy ciąg (klasyczny)", TypeOfExercise.Weight); //Image
            dictionary.Add("Martwy ciąg (sumo)", TypeOfExercise.Weight); //Image
            dictionary.Add("Przysiad", TypeOfExercise.Weight); //Image
            dictionary.Add("Przysiad ze sztangą przodem (Front squad)", TypeOfExercise.Weight); //Image
            dictionary.Add("Prostowanie nóg na maszynie", TypeOfExercise.Weight); //Image
            dictionary.Add("Uginanie nóg na maszynie", TypeOfExercise.Weight); //Image
            dictionary.Add("Spięcia łydek na maszynie", TypeOfExercise.Weight); //Image
            dictionary.Add("Spięcia łydek z obciążeniem stojąc", TypeOfExercise.Weight); //Image

            //Brzuch

            dictionary.Add("Allahy",TypeOfExercise.Weight); //Image
            dictionary.Add("Brzuszki",TypeOfExercise.NoWeight); //Image
            dictionary.Add("Spięcia brzucha leżąc",TypeOfExercise.NoWeight);
            dictionary.Add("Unoszenie nóg w zwisie",TypeOfExercise.NoWeight); //Image
            dictionary.Add("Unoszenie nóg leżąc",TypeOfExercise.NoWeight); //Image
            dictionary.Add("Deska",TypeOfExercise.Time); //Image
            dictionary.Add("Nożyce",TypeOfExercise.Time); //Image

            return dictionary;
        }

    }
}
