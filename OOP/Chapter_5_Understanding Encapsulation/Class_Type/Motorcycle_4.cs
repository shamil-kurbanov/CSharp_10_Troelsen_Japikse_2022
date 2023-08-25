using System;
using static System.Console;

namespace SimpleClassExample;

public class Motorcycle_4
{
    public int driverIntensity;
    public string driverName;

    //Constructor chaining
    public Motorcycle_4()
    {
        WriteLine("In default constructor");
    }
    /*
    public Motorcycle_4(int intensity) : this(in intensity, "")
    {
        WriteLine("In constructor taking an int");
    }

    public Motorcycle_4(string name) : this(0, name)
    {
        WriteLine("In constructor taking a string");
    }
    */

    //This is the 'master' constructor that does all the real work
    public Motorcycle_4(int intensity = 0, string name = "")
    {
        WriteLine("In main constructor");

        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;


    }
}