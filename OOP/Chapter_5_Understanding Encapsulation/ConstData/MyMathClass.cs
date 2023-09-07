using System;
using static System.Console;

namespace ConstData
{
    public class MyMathClass
    {
        public const double PI = 3.14159;

        // Error! Can't assign a value to a const in a constructor!
        // readonly can be assigned in static constructor or at declaration
        public static readonly double PI2; 

        static MyMathClass()
        {
            PI2 = 3.14159;
        }
    }
}