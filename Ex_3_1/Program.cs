using System;

namespace Ex_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите два числа: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double result = 1;
            //result = Math.Pow(A, B); 
            for (int count = 0; count < B; count++)
            {
                result *=  A;
            }
            Console.WriteLine($"{A} в степени {B} будет равно {result}");

        }
    }
}
