using System;
using static System.Console;

namespace FunWithRecords;

class Car{
    public string? Make {get; set;}
    public string? Model {get; set;}
    public string? Color {get; set;}

    //default constructor
    public Car(){}

    //custom constructor
    public Car(string? make, string? model, string? color)
    {
        Make = make;
        Model = model;
        Color = color;
    }

    //Function to print the car details
    public void DisplayCarStats()
    {
        WriteLine($"{Make} {Model} is {Color}");
    }
}