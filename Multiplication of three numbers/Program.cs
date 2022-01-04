// See https://aka.ms/new-console-template for more information

int FirstNumber, SecondNumber, ThirdNumber;

Console.WriteLine("Input the first number to multiply:");
FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number to multiply:");
SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the third number to multiply:");
ThirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{FirstNumber} x {SecondNumber} x {ThirdNumber} = {FirstNumber * SecondNumber * ThirdNumber}");

