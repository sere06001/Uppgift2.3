using System;
namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar tänker du hyra bilen?");
            double dagar = double.Parse(Console.ReadLine());
            double dagarSumma = 300 + (dagar - 1) * 500;
            Console.WriteLine("Hur många km tänker du köra?");
            double km = double.Parse(Console.ReadLine());
            double kmSumma = km;
            double totalaSumma = dagarSumma + kmSumma;
            Console.WriteLine("Det kommer att kosta dig " + totalaSumma + "kr.");
            Console.ReadKey();
        }
    }
}