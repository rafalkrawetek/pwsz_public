using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liczby
{
    public class liczby
    {
        protected int a;
        protected int b;
        protected int c;

        public liczby()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public int getA()
        {
            return a;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public int getB()
        {
            return b;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getC()
        {
            return c;
        }

        public void setC(int c)
        {
            this.c = c;
        }
    }
}