using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using To_do_list.Models;

namespace To_do_list.Engines
{
    static class ObservableCollectionToTXT
    {
        public static string Method(ObservableCollection<item> collection)
        {
            string result = "";

            foreach (var item in collection)
            {
                result += item.Text + ";" + item.Statement + "\n";
            }

            return result;
        }

    }
}
