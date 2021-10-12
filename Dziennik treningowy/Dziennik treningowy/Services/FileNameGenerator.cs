using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dziennik_treningowy.Services
{
    public static class FileNameGenerator
    {
        public static string GetFileName(string path, string textToName)
        {
            string result = "";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

                result += GetNameByDate() + " " + textToName;
                return result;
            }

            string tempCombine = GetNameByDate() + " " + textToName;

            string[] fileEntries = Directory.GetFiles(path);

            if(fileEntries.Length > 0)
            {
                foreach (var file in fileEntries)
                {
                    if(file == tempCombine)
                    {
                        return result;
                    }
                }
            }

            result = tempCombine;

            return result;
        }

        public static string GetNameByDate()
        {
            DateTime dateAndTime = DateTime.Now;
            return dateAndTime.ToString("dd/MM/yyyy");
        }
    }
}
