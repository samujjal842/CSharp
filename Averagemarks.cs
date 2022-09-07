﻿using System;
class Program
{
    public static void Main(String[] args)
    {
        float[] avgMarks = new float[5];
        int maxIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter average mark for student {0} : ", i + 1);
            float val = float.Parse(Console.ReadLine());
            avgMarks[i] = val;
        }

        float maxValue = avgMarks[0];

        for (int i = 1; i < 5; i++)
        {
            if (avgMarks[i] > maxValue) { maxValue = avgMarks[i]; }
        }
        Console.WriteLine("Highest mark obtained is {0}", maxValue);
    }
}