// See https://aka.ms/new-console-template for more information

int num1, num2;

Console.Write("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 == 30 || num2 == 30 || num1 + num2 == 30);