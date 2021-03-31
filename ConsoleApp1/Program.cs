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

        static int CheckIntValue()
        {
                        
            int correctValue;
           
            while (!int.TryParse(Console.ReadLine() , out correctValue))
            {
                Console.WriteLine("Неправильно! Попробуй ещё раз.");
            }
            return correctValue;
        }

        static void Main(string[] args)
        {                       
            Console.Write("Введи кол-во игроков = ");
            int playersCount ;   //реализовать CheckIntValue() что значит number? "число"... назови "playersCount"  например
            bool exit = true;

            do
            {
                playersCount = CheckIntValue();
                if (playersCount <= 0)
                {
                    Console.WriteLine("Неправильно! Попробуй ещё раз.");
                    //from = CheckIntValue();
                    exit = false;
                }
                else exit = true;
            }
            while (exit == false);

            Random rand = new Random();
            int gameNumber = rand.Next(12, 120);
            Console.WriteLine("\nЧисло = " + gameNumber);

            Console.WriteLine("Выбери диапазон чисел для игры");
            //Console.Write("\nВведите От: ");
            //int from = CheckIntValue();   //реализовать CheckIntValue() добавить проверку на минимальное введенное число if(from < ... ) 

            Console.Write("\nВведите От: ");
            int from;            
            
                do
                {
                    from = CheckIntValue();
                    if (from <= 0)
                    {
                    Console.WriteLine("Неправильно! Попробуй ещё раз.");
                    //from = CheckIntValue();
                    exit = false;
                    }
                    else exit = true;                    
                }
                while (exit == false);                      
        
            Console.Write("\nВведите До: ");
            int to ;   //реализовать CheckIntValue() добавить проверку на максимальное введенное число if(to > ... )
            
            do
            {
                to = CheckIntValue();
                if (from >= to)
                {
                    Console.WriteLine("Неправильно! Попробуй ещё раз.");
                    //from = CheckIntValue();
                    exit = false;
                }
                else exit = true;
            }
            while (exit == false);

            int value;

            if (playersCount == 1)
            {
                Console.WriteLine("\nИгра с компом");
                Console.WriteLine("\nВеди свое имя - ");
                string NameUser1 = Console.ReadLine(); //лишние скобки удалил

                while (gameNumber > 0)
                {
                    Console.Write(NameUser1 + " введите число от " + from + " до " + to + " = ");
                    value = CheckIntValue(); //реализовать CheckIntValue()
                    gameNumber -= value;
                    Console.WriteLine("Число = " + gameNumber);
                    Random rand1 = new Random();
                    int NumberPC = rand1.Next(from, to);
                    if (gameNumber <= to)
                    {
                        gameNumber -= gameNumber;
                        //Console.WriteLine("Конец игры");
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
                string[] array = new string[playersCount];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"\nВведи имя игрока № {i + 1} ");
                    array[i] = Console.ReadLine();
                }
                
                for (int i = 0; gameNumber > 0; i++)
                {
                    if (i == array.Length) i = 0;
                    Console.Write("\nИгрок " + array[i] + " введите число от " + from + " до " + to + " = ");
                    value = CheckIntValue(); //реализовать CheckIntValue()
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
