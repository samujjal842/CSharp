using System;
class Calculator
{

    static void Main()
    {
        Console.WriteLine("Enter the length of array");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of array");
        int[] arr = new int[len];
        for (int i = 0; i < len; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Arr(arr);
    }

    public static void Arr(params int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum = sum + num[i];
        }
        Console.WriteLine(sum);
    }
}