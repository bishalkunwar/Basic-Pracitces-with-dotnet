// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Different types of data types in C#.
        int num1 = 5;
        double num2 = 4.556D;
        float num3 = 3.34f;

        string name = "Bishal";
        bool isStudied = true;
        char myLetter = 'B';

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(name);
        Console.WriteLine(isStudied);
        Console.WriteLine(myLetter);
        Console.WriteLine("Basic Data Types Printed");
        Type num1Type = num1.GetType();
        Console.WriteLine(num1Type);

        // Question 1
        byte variable1 = 97;
        sbyte variable2 = -115;
        int variable3 = 52130;
        uint variable4 = 4825932U;
        short variable5 = -10000;

        Console.WriteLine(variable1);
        Console.WriteLine(variable2);
        Console.WriteLine(variable3);
        Console.WriteLine(variable4);
        Console.WriteLine(variable5);

        // Question 2:
        // 34.567839023, 12.345, 8923.1234857,3456.091
        // Note: double can store all four values accurately however float can/may store only 2nd 3rd and 4th value only noy 1st one.
        double doubleData = 34.567839023D;
        // float testFloat = 34.567839023; // error given: Represents a double precision floating point number.
        float fData1 = 12.345f;
        float fData2 = 8923.1234857f;
        float fData3 = 3456.091f;

        Console.WriteLine(doubleData);
        Console.WriteLine(fData1);
        Console.WriteLine(fData2);
        Console.WriteLine(fData3);

        // Write a program that safely compares floating-point numbers with precision of 0.000001.

    }
}