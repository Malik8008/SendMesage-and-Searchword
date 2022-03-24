using System;
using System.Collections.Generic;
using System.Text;

namespace SelectWord
{
    static class Extension
    {
        public static bool Selection(this string sentence, string searched)
        {            
            int i = 0;
            foreach (char c in sentence)
            {
                if (i != searched.Length)
                {
                    if (c == searched[i])
                    {
                        i++;
                    }
                    else if (c != searched[i])
                        i = 0;
                }
                else break;            
            }
            if (i == searched.Length)
                return true;
            else
                return false;
        }
    }
}
