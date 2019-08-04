using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    public abstract class Czworokat
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public virtual void Wypisz(int a, int b, int c, int d)
        {
            Console.WriteLine("Długości boków: {0}, {1}. {2}, {3}.", a, b, c, d);
        }
        public abstract int Pole();
        public Czworokat(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public Czworokat(int a, int b)
        {
            this.a = a;
            this.b = b;
            this.c = a;
            this.d = b;
        }
        public Czworokat()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.d = 0;
        }
    }

}
