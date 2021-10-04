using System;

namespace Ex_3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int operationBufferA = A;
            int operationBufferB = B;
            int digitA;
            int digitB;
            bool answer =false;
            do
            {
                digitA = operationBufferA % 10;
                do
                {
                    digitB = operationBufferB % 10;
                    if (digitA == digitB)
                    {
                        answer = true;
                    }
                   
                    operationBufferB /= 10;
                } while (operationBufferB > 0);
                
                operationBufferA /= 10;
            } while (operationBufferA > 0);
            if (answer)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }

        }
    }
}
