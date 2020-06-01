using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Podaj wysokosc prostokata: ");
            //var ws = Console.ReadLine();
            //int w = int.Parse(ws);
            //Console.Write("Podaj szerokosc prostokata: ");
            //var ss = Console.ReadLine();
            //int s = int.Parse(ss);
            //for (int i = 0; i < w; i++)
            //{
            //    for (int j = 0; j < s; j++)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            Random losowa = new Random();
            int los=(losowa.Next(1, 11));
            int liczba, ile=0;
            do
            {
             
                    
                    Console.Write("Podaj liczbe z zakresu 1-10: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    liczba = int.Parse(Console.ReadLine());
                if (liczba > 10 || liczba < 1)
                {
                    Console.WriteLine("Podales liczbe z poza zakresu!");
                }
                else
                {
                    ile++;
                    if (los == liczba)
                    {
                        Console.WriteLine("Brawo! Zgadles liczbe.");
                    }
                    else if (los > liczba)
                    {
                        Console.ResetColor();
                        Console.WriteLine("Podales za mala liczbe.");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine("Podales za duza liczbe.");
                    }
                }
            }
            while (los != liczba);
            Console.WriteLine("Odgadles liczbe za {0} razem.", ile);
            Console.ReadKey();
        }
    }
}
