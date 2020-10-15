/*1.	Ввести с клавиатуры число в диапазоне от 100 до 100000000 (введенное число проверяется). 
 * Подсчитать количество четных и нечетных цифр в этом числе в процентном отношении.*/

using System;

namespace Lesson_1
{
    class Program
    {
        static void Main()
        {
            short count = 0;
            short countEven = 0;
            short countOdd = 0;
            int N = 0;
            float percentEven = 0;
            float percentOdd = 0;

            try
            {
                Console.Write("Введите число в диапазоне от 100 до 100000000: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 100 && number <= 100000000)
                {
                    int numberConst = number;
                    while (number != 0)
                    {
                        N = number % 10;
                        if (N % 2 == 0)
                            countEven++;
                        else
                            countOdd++;
                        number /= 10;
                        count++;
                    }
                    percentEven = (countEven * 100) / count;
                    percentOdd = (countOdd * 100) / count;
                    Console.WriteLine("Количество четных цифр в числе {0} в процентном соотношении = {1:f}", numberConst, percentEven);
                    Console.WriteLine("Количество нечетных цифр в числе {0} в процентном соотношении = {1:f}", numberConst, percentOdd);
                }
                else
                    Console.WriteLine("Не корректный ввод данных!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

