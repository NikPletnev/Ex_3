using System;

namespace Ex_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число:");
            double A = Convert.ToDouble(Console.ReadLine());
            double rangeMax = A;
            double rangeMin = 0;
            double result = 0;

            while(rangeMax - rangeMin > 0.01)
            {
                result = (rangeMax + rangeMin)/ 2;
                if(result*result > A)
                {
                    rangeMax = result;
                    
                }
                else
                {
                    rangeMin = result;
                }
            }


            Console.WriteLine(result);
        }
    }
}
