using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    public class Prostokat : Czworokat
    {
        public Prostokat(int argA, int argB):base (a, b)
        {

            this.a = argA;
            this.b = argB;
            this.c = argA;
            this.d = argB;
        }

        public override int Pole(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }

    }
}
