using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //тут можно реализовать метод, который будет проверять правильность ввода целых чисел, чтобы не использовать конструкцию int.TryParse везде
        static int CheckIntValue(string value)
        {
            int correctValue;
        // реализация проверки через int.TryParse();
            return correctValue;
        }
        
        static void Main(string[] args)
        {                       
            Console.Write("Введи кол-во игроков = ");
            int number = int.Parse(Console.ReadLine());   //реализовать CheckIntValue() что значит number? "число"... назови "playersCount"  например

            Random rand = new Random();
            int gameNumber = rand.Next(12, 120);
            Console.WriteLine("\nЧисло = " + gameNumber);

            Console.WriteLine("Выбери диапазон чисел для игры");
            Console.Write("\nВведите От: ");
            int from = Convert.ToInt32(Console.ReadLine());  //реализовать CheckIntValue() добавить проверку на минимальное введенное число if(from < ... )
            Console.Write("\nВведите До: ");
            int to = Convert.ToInt32(Console.ReadLine());   //реализовать CheckIntValue() добавить проверку на максимальное введенное число if(to > ... )

            int value;

            if (number == 1)
            {
                Console.WriteLine("\nИгра с компом");
                Console.WriteLine("\nВеди свое имя - ");
                string NameUser1 = Console.ReadLine(); //лишние скобки удалил

                while (gameNumber > 0)
                {
                    Console.Write(NameUser1 + " введите число от " + from + " до " + to + " = ");
                    value = int.Parse(Console.ReadLine()); //реализовать CheckIntValue()
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
                    value = int.Parse(Console.ReadLine()); //реализовать CheckIntValue()
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
                    
                }
            }  

           
        }
    }
}
