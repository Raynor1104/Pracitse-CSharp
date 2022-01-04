// See https://aka.ms/new-console-template for more information

double number1, number2, number3, number4;

Console.Write("Enter the first number: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
number3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the forth number: ");
number4 = Convert.ToDouble(Console.ReadLine());

double average = (number1 + number2 + number3 + number4) / 4;
Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is: {average}");