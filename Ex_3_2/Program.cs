using System;

namespace Ex_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            for (int count = A; count < 1000; count++)
            {
                if(count % A == 0)
                {
                    Console.WriteLine(count);
                }
            }

        }
    }
}
