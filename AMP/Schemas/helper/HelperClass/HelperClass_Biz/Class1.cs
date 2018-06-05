using System;
using System.Collections.Generic;
using System.Text;

namespace StringUtilitiesLibrary
{
    [Serializable]
    public class Concatenation
    {
        public Concatenation()
        { }

        public string Concat(string strParam1, string strParam2)
        {
            return strParam1 + strParam2;
        }
    }
}