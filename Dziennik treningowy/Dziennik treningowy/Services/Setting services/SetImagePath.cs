using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class SetImagePath
    {
        public static string Method(string pickedExercise)
        {
            string result = "";

            switch(pickedExercise)
            {
                //Ez Bar Preacher Curl-Image.jpg



                case "Nożyce":
                    {
                        result += "Scissors.jpg";
                        break;
                    }
                case "Deska":
                    {
                        result += "Plank.jpg";
                        break;
                    }
                case "Unoszenie nóg leżąc":
                    {
                        result += "V.jpg";
                        break;
                    }
                case "Unoszenie nóg w zwisie":
                    {
                        result += "Leg raises.jpg";
                        break;
                    }
                case "Brzuszki":
                    {
                        result += "sit ups.jpg";
                        break;
                    }
                case "Allahy":
                    {
                        result += "Allahy.jpg";
                        break;
                    }
                case "Spięcia łydek z obciążeniem stojąc":
                    {
                        result += "Calf tautness.jpg";
                        break;
                    }
                case "Spięcia łydek na maszynie":
                    {
                        result += "Calf tautness-machine.jpg";
                        break;
                    }
                case "Uginanie nóg na maszynie":
                    {
                        result += "Leg Curl.jpg";
                        break;
                    }
                case "Prostowanie nóg na maszynie":
                    {
                        result += "Leg Extension.jpg";
                        break;
                    }
                case "Przysiad ze sztangą przodem (Front squad)":
                    {
                        result += "Front squad.jpg";
                        break;
                    }
                case "Przysiad":
                    {
                        result += "Squad-Image.jpg";
                        break;
                    }
                case "Martwy ciąg (klasyczny)":
                    {
                        result += "Classic deadlift-Image.jpg";
                        break;
                    }
                case "Martwy ciąg (sumo)":
                    {
                        result += "Classic deadlift-Image.jpg";
                        break;
                    }
                case "Narciarz":
                    {
                        result += "skier.jpg";
                        break;
                    }
                case "Ściąganie wyciągu górnego wąsko":
                    {
                        result += "Pulling lift close grip-Image.jpg";
                        break;
                    }
                case "Ściąganie wyciągu górnego szeroko":
                    {
                        result += "pulldowns.jpg";
                        break;
                    }
                case "Prostowanie na modlitewniku":
                    {
                        result += "prayer pulls.jpg";
                        break;
                    }
                case "Wiosłowanie hantlą w opadzie":
                    {
                        result += "Roving dumbbell-Image.jpg";
                        break;
                    }
                case "Wiosłowanie sztangą":
                    {
                        result += "Roving barbell-Image.jpg";
                        break;
                    }
                case "Wiosłowanie (T-row)":
                    {
                        result += "T row-Image .jpg";
                        break;
                    }
                case "Podciąganie z obciążeniem":
                    {
                        result += "chin up under-Image.jpg";
                        break;
                    }
                case "Podciąganie podchwytem":
                    {
                        result += "chin up under-Image.jpg";
                        break;
                    }
                case "Podciąganie nadchwytem":
                    {
                        result += "Chin up over-Image.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą łamaną chwytem odwrotnym":
                    {
                        result += "forearm press.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą prostą":
                    {
                        result += "Z barbell curl-Image.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą na modlitweniku":
                    {
                        result += "Ez Bar Preacher Curl-Image.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami z suplinacją stojąc":
                    {
                        result += "Dumbbells curls-Image.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami chwytem młotkowym":
                    {
                        result += "Hammer curls-Image.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami z suplinacją siedząc":
                    {
                        result += "Sitting dumbbell curls-Image.jpg";
                        break;
                    }
                case "Uginanie ramienia z hantlą na ławce":
                    {
                        result += "One arm preacher curl-Image.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą łamaną":
                    {
                        result += "Z barbell curl-Image.jpg";
                        break;
                    }
                case "Uginanie ramienia z hantlą na kolanie":
                    {
                        result += "One arm knee curl-Image.jpg";
                        break;
                    }
                case "Wznosy hantli bokiem w opadzie":
                    {
                        result += "Falling side raises-Image.jpg";
                        break;
                    }
                case "Wyciskanie hantli nad głowę (Arnold press)":
                    {
                        result += "Over head dumbbell press-Image.jpg";
                        break;
                    }
                case "Wyciskanie hantli nad głowę":
                    {
                        result += "Over head dumbbell press-Image.jpg";
                        break;
                    }
                case "Wznosy hantlami bokiem":
                    {
                        result += "Side raises - Image.jpg";
                        break;
                    }
                case "Pompki na poręczach z obciążeniem (Dipy)":
                    {
                        result += "Dips.jpg";
                        break;
                    }
                case "Pompki na poręczach (Dipy)":
                    {
                        result += "Dips.jpg";
                        break;
                    }
                case "Wyciskanie francuskie sztangą łamaną (Skull crushery)":
                    {
                        result += "Scull crushers-Image.jpg";
                        break;
                    }
                case "Prostowanie ramion na wyciągu górnym":
                    {
                        result += "Pulling down lift triceps - Image.jpg";
                        break;
                    } 
                case "Pompki diamentowe":
                    {
                        result += "Push up-Image.jpg";
                        break;
                    }
                case "Pompki":
                    {
                        result += "Push up-Image.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce dodatniej":
                    {
                        result += "Dumbbells press.jpg";
                        break;
                    }
                case "Rozpiętki":
                    {
                        result += "Flyers-Image.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce płaskiej":
                    {
                        result += "Dumbbells press.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce ujemnej":
                    {
                        result += "Decline bench dumbbell press-Image.jpg";
                        break;
                    }
                case "Wyciskanie hantli wąskim chwytem":
                    {
                        result += "Close grip dumbbells press.jpg";
                        break;
                    }
                case "OHP":
                    {
                        result += "OHP.jpg";
                        break;
                    }
                case "Wyciskanie sztangi na ławce płaskiej":
                    {
                        result += "Barell_benchpress.jpg";
                        break;
                    }
                default:
                    {
                        result = "";
                        break;
                    }
            }


            return result;
        }
    }
}
