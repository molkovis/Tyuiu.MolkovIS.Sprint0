﻿using Tyuiu.MolkovIS.Sprint0.Task5.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A + B = " + DataService.Addition(1, 5));
        Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
        Console.WriteLine("A * B = " + DataService.Multiplcation(10, 10));
        Console.WriteLine("A / B = " + DataService.Division(5, 0));
        Console.ReadKey();

    }
}