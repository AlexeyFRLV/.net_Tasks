/*Написать программу для решения следующей задачи:
 * Вычислить сумму элементов второй  половины одномерного массива, не превышающих значения минимального  среди элементов с четными номерами. 
 * Исходный массив задавать, используя генерацию случайных чисел. Для генерирования случайных чисел используйте класс Random*/

using System;

namespace Lesson_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, min, sum = 0;
            do
            {
                Console.Write("Введите количество элементов массива (не меньше 2): ");
                size = int.Parse(Console.ReadLine());
                if(size < 2)
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз!");
            } while (size < 2);
            
            int[] arr = new int[size];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            Console.WriteLine("Массив на {0} элементов, заполненный случайными числами в диапазоне [0, 100]:", size);
            PrintArr(arr);

            //Находим минимальный элемент 2й половины массива среди элементов с четным индексом  
            if ((size / 2) % 2 == 0)
                min = arr[size / 2];
            else
                min = arr[(size / 2) + 1];

            for (int i = size/2; i < arr.Length; i++)
            {
                if ((i % 2 == 0) && (min > arr[i]))
                    min = arr[i];
            }

            //Находим сумму
            for (int i = size/2; i < arr.Length; i++)
            {
                if (arr[i] <= min)
                    sum += arr[i];
            }
            Console.WriteLine("\nСумма элементов 2й половины массива, не привышающих значения минимального среди элементов с четными номерами: " + sum);

        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                    Console.Write("{0,5}", arr[i] + " ");
                }
                else
                    Console.Write("{0,5}", arr[i] + " ");
            }  
            Console.WriteLine();
        }
    }
}
