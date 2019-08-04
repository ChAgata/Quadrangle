using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wymiary prostokąta.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Prostokat prostokat = new Prostokat(a, b);
            //Console.WriteLine(prostokat.a +", " + prostokat.b + ", " + prostokat.c + ", " + prostokat.d);
            Console.WriteLine(prostokat.Pole());
            Console.ReadLine();
        }
    }
}
