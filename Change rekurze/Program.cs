using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_rekurze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Program pro výpočet vrácených mincí rekuzí --------");
            Console.Write("Zadej cenu zboží: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej obdržené peníze: ");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
