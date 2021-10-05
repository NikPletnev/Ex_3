using System;

namespace Ex_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int max;
            int min;
            if (A > B)
            {
                max = A;
                min = B;
            }
            else
            {
                max = B;
                min = A;
            }
            for(int count = min; count < max; count++)
            {
                if (count % 7 == 0)
                {
                    result += count;
                }
            }
            Console.WriteLine($"Cумма всех чисел из диапазона от A до B, которые делятся без остатка на 7: {result}");
        }
    }
}
