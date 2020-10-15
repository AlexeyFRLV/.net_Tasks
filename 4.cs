/*Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. 
Используя эту  информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.*/

using System;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string str = Console.ReadLine();
            char[] array = str.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("Your case-sensitive text: ");
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(array[i]) && char.IsUpper(array[i]))
                    array[i] = (char)(Convert.ToInt32(array[i]) + 32);
                else if((char.IsLetter(array[i]) && char.IsLower(array[i])))
                    array[i] = (char)(Convert.ToInt32(array[i]) - 32);
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
