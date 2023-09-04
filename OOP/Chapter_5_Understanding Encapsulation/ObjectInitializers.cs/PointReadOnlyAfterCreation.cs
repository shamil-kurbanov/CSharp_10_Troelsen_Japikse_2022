using System;
using static System.Console;

namespace ObjectInitializers;

public class PointReadOnlyAfterCreation{
    public int X {get; init;}
    public int Y {get; init;}

    public void DisplayStats(){
        WriteLine($"InitOnlySetter: X = {X}, Y = {Y}");
    }

    public PointReadOnlyAfterCreation(int xVal, int yVal){
        X = xVal;
        Y = yVal;
    }

    public PointReadOnlyAfterCreation(){
    }
}