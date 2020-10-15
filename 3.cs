/*Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым 
(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).*/

using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, count = 0;

            Console.Write("Enter the six-digit ticket number: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                temp = number;
                while (temp != 0)
                {
                    temp /= 10;
                    count++;
                }
                if(count == 6)
                    Console.WriteLine(LuckyTicket(number));
                else
                    Console.WriteLine("Your ticket doesn't have anough numbers!");
            }
            else
                Console.WriteLine("Filed input, end of program!");
        }

        static string LuckyTicket(int num)
        {
            int firstPart = 0;
            int secondPart = 0;
            int[] digits = new int[6];

            for(int k = digits.Length - 1; k >= 0; k--)
            {
                digits[k] = num % 10;
                num /= 10;
                if (k >= digits.Length / 2)
                    secondPart += digits[k];
                else
                    firstPart += digits[k];
            }
            if(firstPart == secondPart)
                return "Congratulate! Your ticket is happy.";
            else
                return "Your ticket isn't happy";
        }
    }
}
