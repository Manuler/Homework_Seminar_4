//Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//3, 5-> 243(3⁵)

//2, 4-> 16


namespace Task_1
{
    internal class Program
    {
        public static int searchExp(int a, int b)
        {
            int result = Convert.ToInt32(Math.Pow(a, b));
            return result;
        }

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ведите число a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ведите число b: ");
                int b = int.Parse(Console.ReadLine());

                int result = searchExp(a, b);
                Console.WriteLine($"Число {a} в натуральной степени {b} = {result}");
            }
            catch
            {
                Console.WriteLine("Введено неверное или слишком большое число");
            }
        }
    }
}