using System;
using static System.Console;

namespace CSharp_Arrays;

public static class SimpleArraysOperations{

    public static void SimpleArrays(){
        WriteLine("=> Simple Array Creation");
        //Create and fill an array of 3 integers
        int[] myInts = new int[3];
        //Print default values
        foreach (int i in myInts){
            WriteLine(i);
        }

        //Create the same array with initializer
        int[] myInts2 = new int[3]{10,20,30};
        //Print default values
        foreach (int i in myInts2){
            WriteLine(i);
        }
        WriteLine();

        //Create a 100 item string array, indexed 0 - 99
        string[] booksOnDotNet = new string[100];
        WriteLine();    

    }

    public static void ArrayInitialization(){
        WriteLine("=> Array Initialization");
        //Array initialization syntax using the new keyword

        string[] stringArray = new string[] {"one", "two", "three"};
        WriteLine("stringArray has {0} elements:", stringArray.Length);
        foreach (string s in stringArray){
            WriteLine(s);
        }
    }
}