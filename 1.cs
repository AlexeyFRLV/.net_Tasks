/*1. Даны целые положительные числа A, B, C. Значение этих чисел программа должна запрашивать у пользо-
вателя. На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C. Квадраты не накладываются друг на
друга. Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни
одного квадрата со стороной С (например, если значение С превышает размер сторон прямоугольника).*/

using System;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            int rectangleX = 0, rectangleY = 0, squareX = 0;
            bool menu = true;
            int S = 0;

            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("\t\tВведите целые положительные числа, соответствующие сторонам прямоугольника и квадрата:");
                    Console.WriteLine("Прямоугольник:");
                    Console.Write("\tX = ");
                    rectangleX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\tY = ");
                    rectangleY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Квадрат:");
                    Console.Write("\tX = ");
                    squareX = Convert.ToInt32(Console.ReadLine());
                    menu = (rectangleX > 0 && rectangleY > 0 && squareX > 0) ? false : true;
                    if(menu)
                        Console.WriteLine("Некорректный ввод! Попробуйте еще раз.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Для продолжения нажмите Enter...");
                Console.ReadKey();
            } while (menu);

            int countA = 0;
            int countB = 0;
            int total = 0;
            Console.Clear();
            if (squareX > rectangleX || squareX > rectangleY)
            {
                Console.WriteLine("В прямоугольник нельзя поместить ни одного квадрата!");
            }
            else
            {
                countA = rectangleX / squareX;
                countB = rectangleY / squareX;
                total = countA * countB;

                S = rectangleX * rectangleY - total * squareX * squareX;
                Console.WriteLine("В прямоугольник {0}*{1} вмещается {2} квадратов {3}*{3}", rectangleX, rectangleY, total, squareX);
                Console.WriteLine("Площадь незанятой части прямоугольника = {0}", S);
            }
        }
    }
}