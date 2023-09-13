using System;
using static System.Console;
using BasicInheritance;

WriteLine("***** Basic Inheritance *****\n");

//Make a Car object, set max speed and current speed
Car car = new Car(80){Speed = 50};

//Printcurrent speed
WriteLine($"My car is going {car.Speed} MPH");
WriteLine("\n ------------------ \n");
WriteLine("***** Basic Inheritance *****\n");
// Now make a MiniVan object
MiniVan myMiniVan = new MiniVan { Speed = 10 };
WriteLine($"My MiniVan is going {myMiniVan.Speed} MPH");
