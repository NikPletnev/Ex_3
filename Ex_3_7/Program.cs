using System;

namespace Ex_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            int max = A;
            int rem;
            int min = B;
            if (B > A)
            {
                max = B;
                min = A;
            }
            do
            {
                result = max / min;
                rem = max % min;
                if (rem != 0)
                {
                    max = min;
                    min = rem;
                }
            } while (rem != 0);
            Console.WriteLine($"их наибольший общий делитель {Math.Abs(min)}");

        }
    }
}
