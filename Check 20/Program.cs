// See https://aka.ms/new-console-template for more information

int x, y;

Console.Write("Enter first number: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
y = Convert.ToInt32(Console.ReadLine());

Console.Write(x == 20 || y == 20 || x + y == 20);