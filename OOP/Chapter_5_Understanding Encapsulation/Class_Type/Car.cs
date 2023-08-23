using System;
using static System.Console;

namespace SimpleClassExample;

public class Car
{
    //The 'state' of the Car
    public string petName;
    public int currSpeed;
    
    //The functionality of the Car
    public void PrintState()
    {
        WriteLine($"{petName} is going {currSpeed} MPH");
    }
    public void SpeedUP(int delta) => currSpeed += delta;
}