using System;
using static System.Console;

namespace Understanding_Methods;

public static class ParamsModifier{

    //Return average of "some number" of doubles
    public static double CalculateAverage(params double[] values){
        WriteLine("You sent me {0} doubles", values.Length);

        double sum = 0;
        if(values.Length == 0){
            return sum;
        }

        for(int i = 0; i < values.Length; i++){
            sum += values[i];
        }

        return (sum / values.Length);
    }
}