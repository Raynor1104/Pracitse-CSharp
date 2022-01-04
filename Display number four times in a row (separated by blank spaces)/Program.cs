// See https://aka.ms/new-console-template for more information

int num;
Console.Write("Enter a digit: ");
num = Convert.ToInt32(Console.ReadLine());

// Part A: "num num num num" using Write
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.WriteLine();

// Part B: "numnumnumnum" using Write
        Console.Write( num );
        Console.Write( num );
        Console.Write( num );
        Console.WriteLine( num );
        Console.WriteLine();

Console.WriteLine("{0} {0} {0} {0}" , num);
Console.WriteLine("{0}{0}{0}{0}" , num);
