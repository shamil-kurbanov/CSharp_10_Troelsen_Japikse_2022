/*using System;
using static System.Console;

namespace SimpleClassExample;

public class Motorcycle_2
{
    private int driverIntensity;
    //New members to represent the name of the driver.
    public string driverName;


    public void SetDriverName(string name)
    {
        this.name = name;
    }

    
    public void PopAWheely()
    {
        for (int i = 0; i < driverIntensity; i++)
        {
            WriteLine(i + ". " + "Yeaaaaaaaa Haaaaaeewww!");
        }
    }
    

    //Redundant constructor logic!

    //Put back the default constructor, which will set all data members to default values
    public Motorcycle_2()
    {

    }

    //Our custom constructor
    public Motorcycle_2(int intensity)
    {
        if(intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
    }

    public Motorcycle_2(int intensity, string name)
    {
        if(intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;
    }
}

*/