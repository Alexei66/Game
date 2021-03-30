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

            Console.WriteLine("Введи число ");
            //string numberString = Console.ReadLine();
            int correctValue;
            

            //bool result = int.TryParse(numberString, out correctValue);

            while (!int.TryParse(Console.ReadLine(), out correctValue))
            {
                Console.WriteLine("не число");
                 
                 //result = int.TryParse(Console.ReadLine(), out correctValue);
            }

            Console.WriteLine();



















            /*Console.WriteLine("NameUser1");
            string NameUser1 = (Console.ReadLine());

            Console.WriteLine("NameUser2");
            string NameUser2 = (Console.ReadLine());

            Random rand = new Random();
            int gameNumber = rand.Next(12, 120);

            Console.WriteLine("число = " + gameNumber);

            int value;

            while (gameNumber > 0)
            {
                
                Console.Write(NameUser1 + " Введите число от 1 до 4: ");
                value = int.Parse(Console.ReadLine());
                gameNumber -= value;
                Console.WriteLine("число = " + gameNumber);

                Console.Write(NameUser2 + " Введите число от 1 до 4: ");
                value = int.Parse(Console.ReadLine());
                gameNumber -= value;
                Console.WriteLine("число = " + gameNumber);


            }*/


            // static int CheckIntValue(string value)
            //{








            //}
        }




    }
}
