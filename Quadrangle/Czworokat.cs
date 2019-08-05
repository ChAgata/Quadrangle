﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    public abstract class Czworokat
    {
        protected int a;
        protected int b;
        protected int c;
        protected int d;
        protected virtual void Wypisz(int a, int b, int c, int d)
        {
            Console.WriteLine("Długości boków: {0}, {1}. {2}, {3}.", a, b, c, d);
        }
        public abstract int Pole();
        
        public Czworokat()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.d = 0;
        }
    }

}
