using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    public class Kwadrat:Czworokat
    {
        public Kwadrat(int argA)
        {
            this.a = argA;
            this.b = argA;
            this.c = argA;
            this.d = argA;
        }

        public override int Pole()
        {
            int pole = a * a;
            return pole;
        }
        public string Wymiary(int argA)
        {
            a = argA;
            b = argA;
            c = argA;
            d = argA;
            string wynik = a + ", " + b + ", " + c + ", " + d;
            return wynik;
        }
    }
}
