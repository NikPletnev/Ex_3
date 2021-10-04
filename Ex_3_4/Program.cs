using System;

namespace Ex_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = Convert.ToInt32(Console.ReadLine());
            int maxDivider = 1;
            for (int count =  1; count < Math.Abs(A); count++)
            {
                if(Math.Abs(A) % count == 0)
                {
                    maxDivider = count;
                }
            }
            Console.WriteLine($"аибольший делитель (кроме самого A) числа A: {maxDivider}");
        }
    }
}
