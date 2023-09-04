using System;
using static System.Console;
using AutoProps;

WriteLine("***** Fun with Automatic Properties *****\n");

// Make a car.
Car car1 = new Car();
car1.PetName = "Frank";
car1.Speed = 55;
car1.Color = "Red";
car1.DisplayStats();

WriteLine($"Your car is named {car1.PetName}? That's odd...");
WriteLine("------------------------------------------------");
car1.DisplayStats();
WriteLine("");

// Put car in the garage and print.
Garage garage = new Garage();
garage.MyAuto = car1; // Using the set accessor.
WriteLine($"Number of cars in garage: {garage.NumberOfCars}");
WriteLine($"Your car is named {garage.MyAuto?.PetName}");
WriteLine("------------------------------------------------");

