using _2019_zad._5._1.models;
using _2019_zad._5._2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._5._2.engines
{
    public static class engine
    {
        public static Dates counting(List<Note> list)
        {
            int length = list.Count;

            int firstDay = 0;
            int lastDay = 0;
            int streak = 0;
            int longestStreak = 0;

            for (int i = 440; i < length - 1; i++)
            {
                if (list[i].Temperature < list[i + 1].Temperature)
                {
                    streak++;

                    if (streak > longestStreak)
                    {
                        longestStreak = streak;
                        firstDay = i - longestStreak + 1;
                    }
                }
                else
                {
                    streak = 0;
                }
            }

            lastDay = firstDay + longestStreak;

            Dates dates = new Dates(firstDay, lastDay);

            return dates;
        }
    }
}
