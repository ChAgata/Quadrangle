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

            //2.17
            Czworokat[] tablicaCzworokatow = new Czworokat[]
            {
                new Kwadrat(5),
                new Prostokat(5,3),
                new Kwadrat(7),
                new Prostokat(1,5),
                new Prostokat(2,3)
            };


            var wynik = wypiszPola(tablicaCzworokatow);

            /*foreach (var item in tablicaCzworokatow)
            {
                Console.WriteLine(item.GetType().Name + "Pole: " + item.Pole());
            }*/
            //2.18
            Czworokat[] tablica = new Czworokat[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("K-kwadrat P-prostokąt. Wybierz");
                string czw = Console.ReadLine();
                if (czw == "K")
                {
                    Console.WriteLine("Podaj długość boku.");
                    Kwadrat kw = new Kwadrat(int.Parse(Console.ReadLine()));
                    tablica[i] = kw;
                }
                else if(czw=="P")
                {
                    {
                        Console.WriteLine("Podaj długości 2 boków.");
                        Prostokat pr = new Prostokat(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        tablica[i] = pr;
                    }
                }
            }
            var wynikPol = wypiszPola(tablica);

            //-----------------------------
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
        static int[] wypiszPola(Czworokat[] czw)
        {
            int[] tablicaPol = new int[5];
            int i = 0;
            foreach (var item in czw)
            {
                tablicaPol[i] = item.Pole();
                Console.WriteLine(item.GetType().Name + "; Pole: " + item.Pole());
            }
            return tablicaPol;
        }
    }
}
