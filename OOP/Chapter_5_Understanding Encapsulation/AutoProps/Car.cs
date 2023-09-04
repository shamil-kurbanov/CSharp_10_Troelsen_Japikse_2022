using System;
using static System.Console;

namespace AutoProps;

public class Car{
    //Automatic properties! No need to define backing fields
    public string? PetName{get; set;}
    public int Speed{get; set;}
    public string? Color{get; set;}

    public void DisplayStats(){
        WriteLine($"Car Name: {PetName}");
        WriteLine($"Speed: {Speed}");
        WriteLine($"Color: {Color}");
    }
}