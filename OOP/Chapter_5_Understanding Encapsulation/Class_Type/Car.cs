using System;
using static System.Console;

namespace SimpleClassExample;

public class Car
{
    //The 'state' of the Car
    public string? petName;
    public int currSpeed;
    
    //A custom default constructor
    public Car()
    {
        petName = "Chuck";
        currSpeed = 10;
    }

    //Here currSpeed will receive the default value of an int (zero)
    public Car(string pn)
    {
        petName = pn;
    }

    //Let caller set the full state of the Car
    public Car(string pn, int cs)
    {
        petName = pn;
        currSpeed = cs;
    }

    //Constructors with out Parameters
    public Car(string pn, int cs, out bool inDanger)
    {
        petName = pn;
        currSpeed = cs;
        if (cs > 100)
        {
            inDanger = true;
        }
        else
        {
            inDanger = false;
        }
        WriteLine("In Danger: {0}", inDanger);
    }

    //The functionality of the Car
    public void PrintState()
    {
        WriteLine($"{petName} is going {currSpeed} MPH");
    }
    public void SpeedUP(int delta) => currSpeed += delta;
}