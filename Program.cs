using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_return
{
    class Program
    {
        static int[] mince = { 50, 20, 10, 5, 2, 1};
        static int[] vyskyt;

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                vyskyt = new int[6];

                Console.WriteLine("-------- Program pro výpočet vrácených mincí --------");
                Console.Write("Zadej cenu zboží: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadej obdržené peníze: ");
                int money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------");

                int debt = money - price;
                if (debt == 0)
                {
                    Console.WriteLine("Zaplaceno přesně, není třeba nic vracet!");
                }
                else
                {
                    for (int i = 0; i < mince.Length; i++)
                    {
                        vyskyt[i] = (debt / mince[i]);

                        debt -= vyskyt[i] * mince[i];

                        if (debt == 0) break;
                    }

                    string reson = $"Je třeba vrátit: \n";

                    for (int i = 0; i < vyskyt.Length; i++)
                    {
                        if (vyskyt[i] != 0) reson += $" ~ {vyskyt[i]}x {mince[i]}Kč \n";
                    }

                    Console.WriteLine(reson);
                }

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Pokud chceš skončit, stiskni 'k', jinak jedeme znovu.");
                cki = Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------");


            } while (cki.Key != ConsoleKey.K);

            Console.WriteLine("Papa... ;)");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
