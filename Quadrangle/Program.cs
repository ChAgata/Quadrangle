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
            Czworokat[] tablicaCzworokatow = new Czworokat[]
            {
                new Kwadrat(5),
                new Prostokat(5,3),
                new Kwadrat(7),
                new Prostokat(1,5),
                new Prostokat(2,3)
            };
            foreach(var item in tablicaCzworokatow)
            {
                Console.WriteLine(item.GetType().Name + "Pole: " + item.Pole()); 
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
