using System;
class SwappingNumbers
{

    static void swap(int a, int b)
    {
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("A=" + a + "\nB=" + b);

    }

    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter Value For A ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value For B ");
        b = Convert.ToInt32(Console.ReadLine());
        swap(a, b);


    }
}
