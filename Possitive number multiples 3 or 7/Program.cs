// See https://aka.ms/new-console-template for more information

int number;
Console.Write("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write(number >= 0 && (number % 3 == 0 || number % 7 == 0));
