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
            for (int count = Math.Abs(A); count > 0; count--)
            {
                if(Math.Abs(A) % count == 0 && count != Math.Abs(A))
                {
                    maxDivider = count;
                    break;
                }
            }
            Console.WriteLine($"Наибольший делитель (кроме самого числа {A}) числа {A}: {maxDivider}");
        }
    }
}
