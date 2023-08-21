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
        WriteLine();

        // Array initialization syntax without using the new keyword
        bool[] boolArray = {false, false, true};
        WriteLine("boolArray has {0} elements:", boolArray.Length);
        foreach(bool b in boolArray){
        WriteLine(b);
        }
        WriteLine();

        //Array initialization with new keyword and size
        int[] intArray = new int[4]{20, 22, 23, 0};
        WriteLine("intArray has {0} elements: ", intArray.Length);
        foreach(int i in intArray){
            WriteLine(i);
        }
        WriteLine();
    }

    //DeclareImplicitArrays()
    public static void DeclareImplicitArrays(){
        WriteLine("=> Implicit Array Initialization");

        //a is really int[]
        var a = new[]{1, 10, 100, 1000};
        WriteLine("a is a {0}", a.ToString());

        //b is really double[]
        var b = new[]{1, 1.5, 2, 2.5};
        WriteLine("b is a {0}", b.ToString());
        WriteLine("---> :");
        //die Werte b in einer Zeile ausgeben:
        foreach(var i in b){
            Write(i + ", ");
        }
        WriteLine();

        //c is really string[]
        var c = new[]{"hello", null, "world"};
        WriteLine("c is a {0}", c.ToString());
        foreach(var i in c){
            Write(i + ", ");
        }
        WriteLine();
    }

    //ArrayOfObjects()
    public static void ArrayOfObjects(){
        WriteLine("=> Array of Objects");

        // An array of objects can be anything at all
        object[] myObjects = new object[4];
        myObjects[0] = 10;
        myObjects[1] = true;
        myObjects[2] = new DateTime(1969, 3, 24);
        myObjects[3] = "Form & Void";

        foreach (object obj in myObjects){
            //Print the type and value for each item in array
            WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
        }
        WriteLine();

        foreach(object o in myObjects){
            Write(o + ", ");
        }

    }


}