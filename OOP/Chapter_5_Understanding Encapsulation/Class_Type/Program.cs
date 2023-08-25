using System;
using SimpleClassExample;
using static System.Console;


public static class Program
{
    public static void Main(string[] args)
    {
        WriteLine("***** Fun with Class Types *****");
        Title = "***** Fun with Class Types *****";
        
        
        Car myCar = new Car();
        myCar.petName = "Henry";
        myCar.currSpeed = 10;

        for (int i = 0; i < 10; i++)
        {
            myCar.currSpeed += 5;
            myCar.PrintState();
        }
        
        Car chuck = new Car();
        chuck.PrintState();

        WriteLine("---------------------------");
        Car Jarry = new Car("Jarry", 560);
        Jarry.PrintState();
        
        WriteLine("---------------------------");
        Car Mary = new Car("Mary", 78, out bool inDanger);
        Mary.PrintState();

        WriteLine("---------------------------");
        Motorcycle Harlay = new Motorcycle();
        Harlay.PopAWheely();
       

        WriteLine("---------------------------");
        Motorcycle_3 Harlay_4 = new Motorcycle_3(12, "Bike");
        WriteLine("Rider name is {0}", Harlay_4.driverName);
        WriteLine("Rider intensity is {0}", Harlay_4.driverIntensity);

        WriteLine("---------------------------");
        Motorcycle_4 Harlay_5 = new Motorcycle_4(7, name:"Shamil") ;
        //Harlay_5.SetDriverName("Tiny");
        //Harlay_5.PopAWheely();
        WriteLine("Rider name is {0}", Harlay_5.driverName);
        WriteLine("Rider intensity is {0}", Harlay_5.driverIntensity);


        
    }
}

