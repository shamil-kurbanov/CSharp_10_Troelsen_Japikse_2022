using System;
using static System.Console;

namespace SimpleClassExample;

public static class Program
{
    public static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.petName = "Henry";
        myCar.currSpeed = 10;

        for (int i = 0; i < 10; i++)
        {
            myCar.currSpeed += 5;
            myCar.PrintState();
        }
    }
}

