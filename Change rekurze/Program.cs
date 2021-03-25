using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_rekurze
{
    class Program
    {
        static int[] coins = { 50, 20, 10, 5, 2, 1 };
        static int[] count = new int[6];

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            do
            {
                count = new int[6];
                Console.Clear();
                
                Console.WriteLine("-------- Program pro výpočet vrácených mincí rekuzí --------");
                Console.Write("Zadej cenu zboží: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadej obdržené peníze: ");
                int money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------");
                
                if (GetChange(money - price, 0) == 0)
                {
                    string reson = $"Je třeba vrátit: \n";
                
                    for (int i = 0; i < count.Length; i++)
                    {
                        if (count[i] != 0) reson += $" ~ {count[i]}x {coins[i]}Kč \n";
                    }
                
                    Console.WriteLine(reson);
                }

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Pokud chceš skončit, stiskni 'k', jinak jedeme znovu.");
                cki = Console.ReadKey();
                Console.WriteLine("\n-----------------------------------------------------");


            } while (cki.Key != ConsoleKey.K);

            Console.WriteLine("Papa... ;)");
            System.Threading.Thread.Sleep(2000);
        }

        static int GetChange(int moneyBack, int index)
        {
            if (moneyBack == 0) return moneyBack;
            else 
            {
                count[index] = (moneyBack / coins[index]);

                moneyBack -= count[index] * coins[index];

                return GetChange(moneyBack, index + 1);                
            }
        }
    }
}
