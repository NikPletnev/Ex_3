using System;

namespace Ex_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            string reverseNumber = "";
            int numberBuffer = number;
            while(numberBuffer > 0)
            {
                reverseNumber += numberBuffer % 10;
                numberBuffer /= 10;
            }
         
            Console.WriteLine($"Число {number} наоборот будет {reverseNumber}");
        }
    }
}




