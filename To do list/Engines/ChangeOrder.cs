using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using To_do_list.Models;

namespace To_do_list.Engines
{
    static class ChangeOrder
    {
        public static ObservableCollection<item> Method(ObservableCollection<item> collection, item Item,Direction dir)
        {
            int length = collection.Count;

            for (int i = 0; i < length; i++)
            {
                if(collection[i].Text == Item.Text)
                {
                    int n = i;

                    if(dir == Direction.UP)
                    {
                        if(n == 0)
                            {
                            return collection;
                        }
                        else
                        {
                            var tempItem = collection[n - 1];

                            collection[n - 1] = Item;
                            collection[n] = tempItem;

                            return collection;
                        }
                    }
                    else if(dir == Direction.DOWN)
                    {
                        if(n == length - 1)
                        {
                            return collection;
                        }
                        else
                        {
                            var tempItem = collection[n + 1];
                            collection[n + 1] = Item;
                            collection[n] = tempItem;

                            return collection;
                        }
                    }
                }
            }

            return collection;
        }

    }
}
