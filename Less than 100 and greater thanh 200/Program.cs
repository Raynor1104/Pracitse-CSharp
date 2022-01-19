using System;

namespace Less_than_100_and_greater_thanh_200
{
    class Program
    {
        static void Compare (int a, int b)
        {
            Console.WriteLine(a < 100 && b > 200);
        }
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Enter first number(<100): ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number(>200): ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Compare(firstNumber, secondNumber);
        }
    }
}
