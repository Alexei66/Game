using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // кол-во игроков
            int x; // Число полученное в заданом диапазоне
            int count = 0;

            

            do
            {
                Console.WriteLine("number of players from 1 to 4 - ");  // выбираем кол-во игроков 
                number = Convert.ToInt32(Console.ReadLine());


            } while ();

            Console.WriteLine($"name user {i} ");

            /*do
            {
                Console.Write($"Введите {i}-й результат вступительного испытания: ");
                value = double.Parse(Console.ReadLine());
                average += value;
                i++;
            } while (i <= 10);
            */

        }
    }
}
