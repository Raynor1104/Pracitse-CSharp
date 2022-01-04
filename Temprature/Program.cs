// See https://aka.ms/new-console-template for more information

double celsius;
Console.Write("Enter the amount of celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Kelvin = {celsius + 273.15}");
Console.WriteLine($"Fahrenheit = {celsius * 1.8 + 32}");
