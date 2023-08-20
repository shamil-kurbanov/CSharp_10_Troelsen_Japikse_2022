using System;
using static System.Console;

namespace Data_Types;


public static class ParseOperations{
    public static void ParseFromStringWithParse(){
        WriteLine("=> Data type parsing with TryParse:");

        if(bool.TryParse("True", out bool b)){
            WriteLine("Value of b: {0}", b);
        } else{
            WriteLine("Default value of b: {0}", b);
        }

        string value = "Hello";
        if (double.TryParse(value, out double d)){
            WriteLine("Value of d: {0}", d);
        } else{
            WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
        }

        WriteLine();
    }
}