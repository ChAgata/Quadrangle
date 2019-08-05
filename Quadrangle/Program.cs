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
            int[,] tablicaCzworokatow = new int[5, 4]
            {
                {2,3,2,3 },
                {3,8,3,8 },
                {5,5,5,5 },
                {9,5,9,5 },
                {2,2,2,2 }
            };
            for(int i = 0; i<=4; i++)
            {
                if (tablicaCzworokatow[i, 0] != tablicaCzworokatow[i, 1])
                {
                    Prostokat prst = new Prostokat(tablicaCzworokatow[i, 0], tablicaCzworokatow[i, 1]);
                    Console.WriteLine(prst.Pole());
                }
                else
                {
                    Kwadrat kwdr = new Kwadrat(tablicaCzworokatow[i, 0]);
                    Console.WriteLine(kwdr.Pole());
                }
            }


            Console.WriteLine("Podaj wymiary prostokąta.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Prostokat prostokat = new Prostokat(a, b);
            Console.WriteLine("Wymiary prostokąta");
            Console.WriteLine(prostokat.Wymiary(a, b));
            Console.WriteLine("Pole prostokąta");
            Console.WriteLine(prostokat.Pole());

            Console.WriteLine("Podaj długość boku kwadratu.");

            int c = int.Parse(Console.ReadLine());
            Kwadrat kwadrat = new Kwadrat(c);
            Console.WriteLine("Wymiary kwadratu");
            Console.WriteLine(kwadrat.Wymiary(c));
            Console.WriteLine("Pole kwadratu");
            Console.WriteLine(kwadrat.Pole());
            Console.ReadLine();

            
        }
    }
}
