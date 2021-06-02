using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using To_do_list.Models;

namespace To_do_list.Engines
{
    static class TXTtoObservableCollection
    {
        public static ObservableCollection<item> Method(string path)
        {
            ObservableCollection<item> collection = new ObservableCollection<item>();

            var logFile = File.ReadAllLines(path);
            var logList = new List<string>(logFile);

            foreach (var item in logList)
            {
                var listOfWords = (item.Split(new char[] { ';' }
                                                                )
                                                        ).ToList();

                item Item = new item();
                Item.Text = listOfWords[0];

                if(listOfWords[1] == "True")
                {
                    Item.Statement = true;
                }
                else if(listOfWords[1] == "False")
                {
                    Item.Statement = false;
                }

                collection.Add(Item);
            }


            return collection;
        }
    }
}
