using System;
using static System.Console;

namespace FunWithRecords;

record CarRecord
{
    public string? Make { get; init; }
    public string? Model { get; init; }
    public string? Color { get; init; }

    public CarRecord(){}

    public CarRecord(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }

    //Method to print the car details
    public void DisplayCarStats()
    {
        WriteLine($"{Make} {Model} is {Color}");
    }

}