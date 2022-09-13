//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]

namespace Task_3
{
    internal class Program
    {
        public static int[] CreateArray(int quant)
        {
            int[] array = new int[quant];
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Введите {i}й элемент массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число элементов массива: ");
                int quant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("[" + String.Join(", ", CreateArray(quant)) + "]");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода! Введено не число");
            }
        }
    }
}