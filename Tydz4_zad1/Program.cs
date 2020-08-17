using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydz4_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę");
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Podano nie liczby całkowite");
            }


            Console.ReadKey();
        }
    }
}
