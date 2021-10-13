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
                        result += "LegRaises.jpg";
                        break;
                    }
                case "Brzuszki":
                    {
                        result += "SitUps.jpg";
                        break;
                    }
                case "Allahy":
                    {
                        result += "Allahy.jpg";
                        break;
                    }
                case "Spięcia łydek z obciążeniem stojąc":
                    {
                        result += "CalfTautness.jpg";
                        break;
                    }
                case "Spięcia łydek na maszynie":
                    {
                        result += "CalfTautnessMachine.jpg";
                        break;
                    }
                case "Uginanie nóg na maszynie":
                    {
                        result += "LegCurl.jpg";
                        break;
                    }
                case "Prostowanie nóg na maszynie":
                    {
                        result += "LegExtension.jpg";
                        break;
                    }
                case "Przysiad ze sztangą przodem (Front squad)":
                    {
                        result += "FrontSquad.jpg";
                        break;
                    }
                case "Przysiad":
                    {
                        result += "Squad.jpg";
                        break;
                    }
                case "Martwy ciąg (klasyczny)":
                    {
                        result += "ClassicDeadlift.jpg";
                        break;
                    }
                case "Martwy ciąg (sumo)":
                    {
                        result += "ClassicDeadlift.jpg";
                        break;
                    }
                case "Narciarz":
                    {
                        result += "skier.jpg";
                        break;
                    }
                case "Ściąganie wyciągu górnego wąsko":
                    {
                        result += "PullingLiftCloseGrip.jpg";
                        break;
                    }
                case "Ściąganie wyciągu górnego szeroko":
                    {
                        result += "pulldowns.jpg";
                        break;
                    }
                case "Prostowanie na modlitewniku":
                    {
                        result += "PrayerPulls.jpg";
                        break;
                    }
                case "Wiosłowanie hantlą w opadzie":
                    {
                        result += "RovingDumbbell.jpg";
                        break;
                    }
                case "Wiosłowanie sztangą":
                    {
                        result += "RovingBarbell.jpg";
                        break;
                    }
                case "Wiosłowanie (T-row)":
                    {
                        result += "Trow.jpg";
                        break;
                    }
                case "Podciąganie z obciążeniem":
                    {
                        result += "ChinUpUnder.jpg";
                        break;
                    }
                case "Podciąganie podchwytem":
                    {
                        result += "ChinUpUnder.jpg";
                        break;
                    }
                case "Podciąganie nadchwytem":
                    {
                        result += "ChinUpOver.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą łamaną chwytem odwrotnym":
                    {
                        result += "ForearmPress.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą prostą":
                    {
                        result += "ZBarbellCurl.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą na modlitweniku":
                    {
                        result += "EzBarPreacherCurl.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami z suplinacją stojąc":
                    {
                        result += "DumbbellsCurls.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami chwytem młotkowym":
                    {
                        result += "HammerCurls.jpg";
                        break;
                    }
                case "Uginanie ramion z hantlami z suplinacją siedząc":
                    {
                        result += "SittingDumbbellCurls.jpg";
                        break;
                    }
                case "Uginanie ramienia z hantlą na ławce":
                    {
                        result += "OneArmPreacherCurl.jpg";
                        break;
                    }
                case "Uginanie ramion ze sztangą łamaną":
                    {
                        result += "Z barbell curl-Image.jpg";
                        break;
                    }
                case "Uginanie ramienia z hantlą na kolanie":
                    {
                        result += "OneArmKneeCurl.jpg";
                        break;
                    }
                case "Wznosy hantli bokiem w opadzie":
                    {
                        result += "FallingSideRaises.jpg";
                        break;
                    }
                case "Wyciskanie hantli nad głowę (Arnold press)":
                    {
                        result += "OverHeadDumbbellPress.jpg";
                        break;
                    }
                case "Wyciskanie hantli nad głowę":
                    {
                        result += "OverHeadDumbbellPress.jpg";
                        break;
                    }
                case "Wznosy hantlami bokiem":
                    {
                        result += "SideRaises.jpg";
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
                        result += "ScullCrushers.jpg";
                        break;
                    }
                case "Prostowanie ramion na wyciągu górnym":
                    {
                        result += "PullingDownLiftTriceps.jpg";
                        break;
                    } 
                case "Pompki diamentowe":
                    {
                        result += "PushUp.jpg";
                        break;
                    }
                case "Pompki":
                    {
                        result += "PushUp.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce dodatniej":
                    {
                        result += "DumbbellsPress.jpg";
                        break;
                    }
                case "Rozpiętki":
                    {
                        result += "Flyers.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce płaskiej":
                    {
                        result += "DumbbellsPress.jpg";
                        break;
                    }
                case "Wyciskanie hantli na ławce ujemnej":
                    {
                        result += "DeclineBenchDumbbellPress.jpg";
                        break;
                    }
                case "Wyciskanie hantli wąskim chwytem":
                    {
                        result += "CloseGripDumbbellsPress.jpg";
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
