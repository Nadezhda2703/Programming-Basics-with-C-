using System;
namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double dollars = double.Parse(Console.ReadLine());
            double rate = 1.79549;
            
            //calculation
                double leva = dollars * rate;
            //output
            Console.WriteLine(leva);
        }
    }
}