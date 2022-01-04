// See https://aka.ms/new-console-template for more information

int num1, num2, sum;

Console.Write("First number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

sum = num1 + num2;

if (num1 == num2)
{
    sum = sum * 3;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine(sum);
}