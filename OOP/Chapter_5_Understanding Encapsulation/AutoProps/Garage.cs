using System;
using static System.Console;

namespace AutoProps;

public class Garage{
    //The hidden int backing field is set to zero!
    public int NumberOfCars{get; set;}

    //The hidden Car backing field is set to null!
    public Car? MyAuto{get; set;}

    // Must use constructors to override default values 
    // assigned to hidden backing fields.
    public Garage(){
        MyAuto = new Car();
        NumberOfCars = 1;
    }

    public Garage(Car car, int number){
        MyAuto = car;
        NumberOfCars = number;
    }

    /*
     * With this modification, you can now place a Car object 
     * into the Garage object and retrieve it later:
    */
    public void Display(){
        WriteLine($"Number of cars: {NumberOfCars}");
        WriteLine($"Your car is named: {MyAuto?.PetName ?? "NoName"}");
    }
}