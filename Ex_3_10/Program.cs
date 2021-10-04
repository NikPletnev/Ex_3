using System;

namespace Ex_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverseNumber = number;
            int numberBuffer = number;
            int count=0;
            int digit;
            int result = 0;
            while (numberBuffer >= 1)
            {
                numberBuffer /= 10;
                count++;
            }
            Console.WriteLine(count);
            numberBuffer = number;
            for(int forCount = 0; forCount<count; forCount++)
            {
                digit = numberBuffer % 10;
                numberBuffer /= 10;
                result = result + (digit * (int)Math.Pow(10, (count-forCount-1)));
            }

            Console.WriteLine($"Число {number} наоборот будет {result}");
        }
    }
}
