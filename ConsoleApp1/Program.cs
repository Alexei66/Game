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
            Console.Write("Введи кол-во игроков = ");
            int number = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int gameNumber = rand.Next(12, 120);
            Console.WriteLine("\nЧисло = " + gameNumber);

            Console.WriteLine("Выбери диапазон чисел для игры");
            Console.Write("\nВведите От: ");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите До: ");
            int to = Convert.ToInt32(Console.ReadLine());

            int value;

            if (number == 1)
            {
                Console.WriteLine("\nИгра с компом");
                Console.WriteLine("\nВеди свое имя - ");
                string NameUser1 = (Console.ReadLine());

                while (gameNumber > 0)
                {
                    Console.Write(NameUser1 + " введите число от " + from + " до " + to + " = ");
                    value = int.Parse(Console.ReadLine());
                    gameNumber -= value;
                    Console.WriteLine("Число = " + gameNumber);
                    Random rand1 = new Random();
                    int NumberPC = rand1.Next(from, to);
                    if (gameNumber <= to)
                    {
                        gameNumber -= gameNumber;
                        Console.WriteLine("Комп победил");
                    }
                    else
                    {
                        gameNumber -= NumberPC;
                        Console.WriteLine("Комп выбрал = " + NumberPC + " остается " + gameNumber);
                    }                                  
                }                
            }
            else
            {
                string[] array = new string[number];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"\nВведи имя игрока № {i + 1} ");
                    array[i] = Console.ReadLine();
                }
                
                for (int i = 0; gameNumber > 0; i++)
                {
                    if (i == array.Length) i = 0;
                    Console.Write("\nИгрок " + array[i] + " введите число от " + from + " до " + to + " = ");
                    value = int.Parse(Console.ReadLine());
                    if (value <= to && value >= from)
                    {
                        gameNumber -= value;
                    }
                    else
                    {
                        Console.WriteLine("Введи новое число");
                        i--;
                        continue;                        
                    }
                    Console.WriteLine("\nЧисло = " + gameNumber);
                    if (gameNumber <= 0) Console.WriteLine("Победил " + array[i]);
                    //test

                }
            }  

           
        }
    }
}
