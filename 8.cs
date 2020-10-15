/*2. Написать программу, которая выводит «бегущую строку» (строку, которая перемещается слева направо).*/

using System;
using System.Threading;

namespace Lesson_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\"Бегущая строка\"");
            Console.WriteLine("Введите текст, который будет содержать бегущая строка:");
            string Ticker = Console.ReadLine();
            Console.WriteLine("Нажмите <Enter> для старта программы! (Для останова нажмите Ctrl+C)");
            Console.ReadLine();
            while (true)
            {
                for (int i = 0; i < 70; i++)
                {
                    Console.Write(Ticker);
                    Thread.Sleep(80);
                    Console.Clear();
                    Console.SetCursorPosition(i, 5);
                }
            }
        }
    }
}
