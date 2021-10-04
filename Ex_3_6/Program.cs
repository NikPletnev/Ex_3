using System;

namespace Ex_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int fibbonachiNumber = 0;
            int fibbonachiNumberPast_1 = 0;
            int fibbonachiNumberPast_2 = 1;

            for (int count  = 2; count<=N; count++)
            {
                fibbonachiNumber = fibbonachiNumberPast_1 + fibbonachiNumberPast_2;
                fibbonachiNumberPast_2 = fibbonachiNumber - fibbonachiNumberPast_2;
                fibbonachiNumberPast_1 = fibbonachiNumber;
                Console.WriteLine(fibbonachiNumber);

            }
            Console.WriteLine($"{N}-ое число ряда фибоначчи: {fibbonachiNumber}"); 
        }
    }
}
