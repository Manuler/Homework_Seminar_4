//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

namespace Task_2
{
    internal class Program
    {
        public static int SumNumbers(int num)
        {
            int total = 0;
            for (int i = 0; num > 0; i++)
            {
                total += num % 10;
                num = num / 10;
            }
            return total;
        }

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число: ");
                int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Сумма цифр в числе {num} = {SumNumbers(num)} ");
            }
            catch
            {
                Console.WriteLine("Ошибка! Вы ввели не число, или число слишком большое");
            }
        }
    }
}