using Liczenie_makroskładników.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static class CheckIfStringIsCorrect
    {
        public static StringIsCorrectModel CheckIfStringIsCorrectMethod(string s, char c)
        {
            var model = new StringIsCorrectModel();

            int textLength = s.Length;

            if(textLength == 0)
            {
                model.Text = s;
                model.IsFloat = false;

                return model;
            }
            else
            {
                bool isDigit = Char.IsDigit(c);

                if(isDigit == true)
                {
                    if (StringContainFlaotingPoint.StringContainFlaotingPointMethod(s) == true)
                    {
                        model.Text = s + c.ToString();
                        model.IsFloat = true;
                    }
                    else
                    {
                        if(textLength == 1)
                        {
                            if(s[0] == '0')
                            {
                                model.Text = s;
                                model.IsFloat = false;
                            }
                            else
                            {
                                model.Text = s + c.ToString();
                                model.IsFloat = false;
                            }
                        }
                        else
                        {
                            model.Text = s + c.ToString();
                            model.IsFloat = false;
                        }
                    }

                }
                else if(c == ',')
                {
                    if(StringContainFlaotingPoint.StringContainFlaotingPointMethod(s) == true)
                    {
                        model.Text = s;
                        model.IsFloat = true;
                    }
                    else
                    {
                        model.Text = s + c.ToString();
                        model.IsFloat = true;
                    }
                }
            }

            
            return model;
        }

    }
}
