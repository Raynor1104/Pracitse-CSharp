// See https://aka.ms/new-console-template for more information

int a, b ,c;

Console.Write("Enter first number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Largest of three: {Math.Max(a, (Math.Max(b, c)))}");
Console.WriteLine($"Lowest of three: {Math.Min(a, (Math.Min(b, c)))}");
