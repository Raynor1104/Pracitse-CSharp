using System;

namespace The_biggest_number
{
    class Program
    {
        static int TheBiggestNumber(int[] a)
        {
            int max = a[0];
            int i;

            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] {6,4,8,1,0,2};
            Console.WriteLine($"The biggest number: {TheBiggestNumber(a)}");
        }
    }
}
