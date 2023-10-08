﻿using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            CheckNumber(number);
        }

        static void CheckNumber (int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.", number);
            }
            else { Console.WriteLine($"The number {number} is zero.", number); }
        }

    }
}
