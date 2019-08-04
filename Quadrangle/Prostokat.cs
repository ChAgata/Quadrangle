using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    public class Prostokat : Czworokat
    {
        public Prostokat(int argA, int argB)
        {
            this.a = argA;
            this.b = argB;
            this.c = argA;
            this.d = argB;
        }

        public override int Pole()
        {
            int pole = a * b;
            return pole;
        }
        public Prostokat Wymiary(int argA, int argB)
        {
            a = argA;
            b = argB;
            c = argA;
            d = argB;
            return 
        }
    }
}
