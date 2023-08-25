using System;
using static System.Console;

namespace SimpleClassExample;

public class Motorcycle_3
{
    public int driverIntensity;
    public string driverName;

    //Constructor chaining
    public Motorcycle_3()
    {

    }
    /*
    public Motorcycle_3(int intensity) : this(in intensity, "")
    {

    }

    public Motorcycle_3(string name) : this(0, name)
    {

    }
    */

    //This is the 'master' constructor that does all the real work
    public Motorcycle_3(int intensity, string name)
    {
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;


    }
}