using System;
using static System.Console;

namespace ObjectInitializers;

public class Point{
    public int X{get; set;}
    public int Y{get; set;}

    public Point(int xVal, int yVal){
        X = xVal;
        Y = yVal;
    }

    public Point(){
    }

    public void DisplayStats(){
        WriteLine($"X = {X}, Y = {Y}");
    }
}