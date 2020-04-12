using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liczby
{
    public class lepsze_liczby : liczby
    {
        protected int d;

        public lepsze_liczby() : base()
        {
            d = 0;
        }

        public int getD()
        {
            return d;
        }

        public void setD(int d)
        {
            this.d = d;
        }
    }
}