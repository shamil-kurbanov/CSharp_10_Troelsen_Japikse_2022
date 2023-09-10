using System;
using static System.Console;

namespace BasicInheritance;

public class Car
{
    // A simple basic class

    public readonly int MaxSpeed;
    private int _currSpeed;

    public Car(int max)
    {
        MaxSpeed = max;
    }

    public Car()
    {
        MaxSpeed = 55;
    }

    public int Speed
    {
        get { return _currSpeed; }

        set
        {
            _currSpeed = value;
            if (_currSpeed > MaxSpeed)
            {
                _currSpeed = MaxSpeed;
            }
        }
    }
}