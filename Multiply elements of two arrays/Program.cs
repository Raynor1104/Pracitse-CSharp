// See https://aka.ms/new-console-template for more information

int i, n;
int[] a = new int[100];
int[] b = new int[100];

Console.Write("Enter array length: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter elements of first array:");
for (i = 0; i < n; i++)
{
    Console.Write("Element [{0}]: ", i);
    a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter elements of second array:");
for (i = 0; i < n; i++)
{
    Console.Write("Element [{0}]: ", i);
    b[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Array 1: ");
for (i = 0; i < n; i++)
{
    Console.Write($"{a[i]} ");
}

Console.Write("\nArray 2: ");
for (i = 0; i < n; i++)
{
    Console.Write($"{b[i]} ");
}

Console.WriteLine("\nMultiply corresponding elements of two arrays:");
for (i = 0; i < n; i++)
{
    Console.Write(a[i] * b[i] +" ");
}
