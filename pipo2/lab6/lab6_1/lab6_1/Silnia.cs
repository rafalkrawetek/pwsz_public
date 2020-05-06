using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class Silnia
    {
        public int n;
        public int oblicz()
        {
            if (n == 0) return 1;
            else return n-- * oblicz();
        }
    }
}
