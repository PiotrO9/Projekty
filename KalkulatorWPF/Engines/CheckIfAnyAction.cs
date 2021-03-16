using KalkulatorWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF.Engines
{
    public static class CheckIfAnyAction
    {
        public static AnyActionModel CheckIfAnyActionExists(string s)
        {
            var FoundAction = new AnyActionModel();
            FoundAction.IsActionFound = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '*' || s[i] == '/')
                {
                    FoundAction.TypeOfAction = s[i];
                    FoundAction.IndexOfAction = i;
                    FoundAction.IsActionFound = true;
                }
            }


            return FoundAction;
        }
    }
}
