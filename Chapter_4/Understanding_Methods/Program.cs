using System;
using static System.Console;

namespace Understanding_Methods;

public static class Program
{
    public static void Main(string[] args)
    {
        WriteLine("***** Fun with Methods *****");
        Title = "***** Fun with Methods *****";
        //int x;
        //int y;
        //WriteLine($"{x} + {y} = " + Add(x, y));
        //WriteLine($"{x} + {y} = " + AddWrapper(x, y));

        //Pass two variables in by value
        string str1 = "Flip";
        string str2 = "Flop";
        Console.WriteLine("Before: {0}, {1} ", str1, str2);
        SwapStringsFunction(ref str1, ref str2);
        Console.WriteLine("After: {0}, {1} ", str1, str2);
        Console.ReadLine();
        
        WriteLine("-----------------------------");
        double average = ParamsModifier.CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
        WriteLine("Average of data is: {0}", average);	
        WriteLine("-----------------------------");
        ReadLine();

        double[] data = {4.0, 0.2, 5.7};
        WriteLine("Average of data id {0}", ParamsModifier.CalculateAverage(data));
        ReadLine();
    }

    public static int Add(int x, int y) => x + y;

    public static int AddWrapper(int x, int y)
    {
        return Add();

        int Add() => x + y;
    }

    //This method swaps the contents of two string variables
    public static void SwapStringsFunction(ref string s1, ref string s2){

    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}

} 