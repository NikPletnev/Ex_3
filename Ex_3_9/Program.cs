using System;

namespace Ex_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count=0;
            int operationBuffer = number;
            
            while (operationBuffer >= 1)
            {
                if((operationBuffer % 10)%2 != 0 && (operationBuffer % 10) !=0)
                {
                    count++;
                }
                
                operationBuffer /= 10;
            }

            Console.WriteLine($"Количество ченых числе в числе {number} состовляет {count}");
        }
    }
}
