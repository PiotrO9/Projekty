using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Interfaces
{
    interface IExercise
    {
        string Name { get; set; }
        int Time { get; set; }
    }
}
