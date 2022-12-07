// Created by: sophie
// Created on: oct 2020
//
// This program calculates area and perimeter of a rectangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;

        int count = 0;

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("divided by: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int remainder = num1;

        if ((num1 > 0 && num2 > 0) && num1 > num2)
        {
            while (remainder > num2 || remainder == num2)
            {
                remainder -= num2;

                count++;
            }
            Console.WriteLine(num1 + " ÷ " + num2 + " = " + count + " R " + remainder);
        }
        else
        {
            Console.WriteLine("please enter a POSITIVE integer that is NOT 0 and please make the first number larger");
        }

        Console.WriteLine("\nDone.");
    }
}