/*Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое
число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению 
(например, число 3 выводится 3 раза).*/

using System;

namespace Lesson_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int A, B;

            do
            {
                Console.Clear();
                Console.WriteLine("Введите два положительных числа А и В (А < В):");
                Console.Write("А = ");
                A = int.Parse(Console.ReadLine());
                Console.Write("В = ");
                B = int.Parse(Console.ReadLine());

                if (A < 0 || B < 0)
                    Console.WriteLine("Некорректный ввод, введённое(-ые) число(-а) меньше 0!!!");
                else 
                    if (A > B)
                        Console.WriteLine("Введенные числа не удовлетворяют условию задачи!!!");
                    else
                        break;
                Console.WriteLine("Нажмите <Enter> для продолжения...");
                Console.ReadLine();
            } while (menu);

            Console.Clear();
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
