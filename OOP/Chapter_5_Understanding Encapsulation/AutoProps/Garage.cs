using System;
using static System.Console;

namespace AutoProps;

public class Garage{
    //The hidden int backing field is set to zero!
    public int NumberOfCars{get; set;}

    //The hidden Car backing field is set to null!
    public Car? MyAuto{get; set;}
}