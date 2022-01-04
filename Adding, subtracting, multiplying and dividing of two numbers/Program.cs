// See https://aka.ms/new-console-template for more information

int a, b;

Console.Write("Input the first number:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number:");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} x {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");
Console.WriteLine($"{a} % {b} = {a % b}");

