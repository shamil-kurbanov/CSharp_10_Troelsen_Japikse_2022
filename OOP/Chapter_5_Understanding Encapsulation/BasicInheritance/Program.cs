using System;
using static System.Console;
using BasicInheritance;

WriteLine("***** Basic Inheritance *****\n");

//Make a Car object, set max speed and current speed
Car car = new Car(80){Speed = 50};

//Printcurrent speed
WriteLine($"My car is going {car.Speed} MPH");