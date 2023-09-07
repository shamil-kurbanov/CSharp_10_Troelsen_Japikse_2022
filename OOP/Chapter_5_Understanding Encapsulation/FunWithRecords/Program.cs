using System;
using static System.Console;
using FunWithRecords;

WriteLine("***** Fun with Records *****\n");
WriteLine("-------------------------");
// Make a car using object initializer syntax.
Car myCar = new Car 
{
    Make = "Honda",
    Model = "Civic",
    Color = "Red"
};

WriteLine("My car: ");
myCar.DisplayCarStats();

WriteLine("-------------------------");

// Make another car using custom constructor syntax
Car anotherCar = new Car(
    "BMW",
    "Mini",
    "Black"
);

WriteLine("Another car: ");
anotherCar.DisplayCarStats();
WriteLine("-------------------------");

myCar.Color = "Black";
WriteLine("My car: ");
myCar.DisplayCarStats();
WriteLine("-------------------------");

// Make a car using record syntax
WriteLine("*** Records ***\n");

//use object initializer syntax
CarRecord myCarRecord = new CarRecord
{
    Make = "Honda",
    Model = "Civic",
    Color = "Red"
};

WriteLine("My car: ");
myCarRecord.DisplayCarStats();

//use custom constructor syntax
CarRecord anotherCarRecord = new CarRecord(
    "BMW",
    "Mini",
    "Black"
);

WriteLine("Another car: ");
WriteLine(anotherCarRecord.ToString());
anotherCarRecord.DisplayCarStats();
