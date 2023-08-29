using System;
using static System.Console;
using OopExamples;

class Program{
    public static void Main(string[] args){
        WriteLine("***** Fun with Encapsulation *****\n");
        Title = "***** Fun with Encapsulation *****\n";

        //Make a car
        OopExamples.Car viper = new Car();
        viper.TurnOnRadio(true);
    }
}   