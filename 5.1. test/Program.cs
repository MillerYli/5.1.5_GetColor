using System;
using System.Drawing;

namespace MainSpase
{
    class Program
    {
        static string GetColor()
        {
            Console.WriteLine("Введите свой любимый цвет на английском, с маленькой буквы");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("This is your super color!");
                    break;
            }
            return color;
        }
    
       public static void Main(string[] args)
        {
            var favecolor = new string[3];

            for(int i = 0; i < favecolor.Length; i++)
            {
                favecolor[i] = GetColor();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach(var color in favecolor)
            {
                Console.WriteLine(color);
            }
        }
    }
}