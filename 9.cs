/*3. Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы. 
 * По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести найденное количество месяцев K и итоговый размер вклада S.*/

using System;

namespace Lesson_1_3
{
    class Lesson1_3
    {
        static void Main()
        {
            try
            {
                decimal S = 1000;   //Начальный вклад в банке
                Console.WriteLine("Размер вашего вклада состовляет {0} руб.", S);
                Console.Write("Введите на сколько % в месяц будет увеличиваться ваш вклад: ");
                double P = double.Parse(Console.ReadLine());
                int month = 0;
                for(int i = 0; S < 1100; i++)
                {
                    decimal rubP = S * (decimal)(P / 100);
                    S += rubP;
                    month++;
                }
                Console.WriteLine("Через {0} месяца(ев) размер вашего вклада будет равен {1:f4} руб.", month, S);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}