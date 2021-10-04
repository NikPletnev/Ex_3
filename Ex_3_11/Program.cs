using System;

namespace Ex_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int operationBuffer;
            int evenSum = 0;
            int oddSum = 0;
            for (int count = 0; count <N; count++)
            {
                operationBuffer = count;
                while (operationBuffer >= 1)
                {
                    if ((operationBuffer % 10) % 2 != 0 && (operationBuffer % 10) != 0)
                    {
                        oddSum += operationBuffer % 10;
                    }
                    if ((operationBuffer % 10) % 2 == 0 && (operationBuffer % 10) != 0)
                    {
                        evenSum += operationBuffer % 10;
                    }

                    operationBuffer /= 10;
                }
                if (evenSum > oddSum)
                {
                    Console.WriteLine(count);
                }
                oddSum = 0;
                evenSum = 0;
            }

        }
    }
}
