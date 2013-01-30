using System;
using System.Collections.Generic;
using System.Text;

namespace BirkaPrint2
{
    public class LabelTextsClass
    {
        public string Normal;
        public string Stp;
        public LabelTextsClass(string n, string s = null)
        {
            this.Normal = n;
            this.Stp = s != null ? s : n;
        }

        public string Text(bool stp)
        {
            return stp ? Stp : Normal;
        }
    }
}
