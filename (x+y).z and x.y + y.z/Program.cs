// See https://aka.ms/new-console-template for more information

int x, y, z;

Console.Write("Enter the first number: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result of specified numbers {x}, {y} and {z},(x+y).z is {(x + y) * z} and x.y + y.z is {x*y + y*z}");