// See https://aka.ms/new-console-template for more information

int FirstNumber, SecondNumber, temp;

Console.WriteLine("Input the First Number : ");
FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the Second Number : ");
SecondNumber = Convert.ToInt32(Console.ReadLine());

temp = FirstNumber;
FirstNumber = SecondNumber;
SecondNumber = temp;

Console.WriteLine("After Swapping :");
Console.WriteLine("First Number: "+ FirstNumber);
Console.WriteLine("Second Number: "+ SecondNumber);

