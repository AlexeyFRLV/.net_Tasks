/*Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
 *Программа должна сосчитать количество введенных пользователем пробелов. */

using System;

namespace Lesson_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(true)
            {
                Console.Clear();
                Console.Write("Enter your character: ");
                char symbol = Console.ReadKey().KeyChar;
                if (symbol == ' ')
                    count++;
                if (symbol == '.')
                    break;
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"Number of spaces: {count}");
        }
    }
}
