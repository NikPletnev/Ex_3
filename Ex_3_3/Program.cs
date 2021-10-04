using System;

namespace Ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число:");
            int A = Convert.ToInt32(Console.ReadLine());
            int count;
            for(count = 0; Math.Pow(count, 2) < A; count++)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine($"Rоличество положительных целых чисел, квадрат которых меньше A: {count}");
        }
    }
}
