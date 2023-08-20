using System;

using static System.Console;

namespace Data_Types;


public static class DataTypeOperations
    {
        public static void DataTypeFunctionality()
        {
            // Ihre Implementierung hier
            WriteLine("DataTypeFunctionality wurde aufgerufen");
            WriteLine("***** Fun with Data Types *****\n");
            WriteLine("=> Data type Functionality:");
            WriteLine("Max of int: {0}", int.MaxValue);
            WriteLine("Min of int: {0}", int.MinValue);
            WriteLine("Max of double: {0}", double.MaxValue);
            WriteLine("Min of double: {0}", double.MinValue);  
            WriteLine("double.Epsilon: {0}", double.Epsilon);
            WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            WriteLine("bool.FalseString: {0}", bool.FalseString);
            WriteLine("bool.TrueString: {0}", bool.TrueString);
            WriteLine();
            Beep();
        }
    }