/*Дано целое число N большее 0, найти число, полученное при прочтении числа N справа налево. 
 *Например, если было введено число 345, то программа должна вывести число 543.*/

using System;

namespace Lesson_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, N;

            do
            {
                Console.WriteLine("Введите целое число > 0:");
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                    Console.WriteLine("Некорректный ввод!!!");
            } while (number < 0);

            N = number;
            Console.Write("Число {0} наоборот - ", number);
            while(true)
            {
                if (N != 0)
                {
                    Console.Write(N % 10);
                    N /= 10;
                }
                else
                    break;
                    
            }
            Console.WriteLine();
        }
    }
}
