// See https://aka.ms/new-console-template for more information

int num1, num2;

Console.Write("Input first integer: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Check if one is negative and one is positive:");
Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));


