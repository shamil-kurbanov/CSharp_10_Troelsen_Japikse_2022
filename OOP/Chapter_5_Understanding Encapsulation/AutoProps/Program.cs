using System;
using static System.Console;
using AutoProps;

WriteLine("***** Fun with Automatic Properties *****\n");

Car car1 = new Car();
car1.PetName = "Frank";
car1.Speed = 55;
car1.Color = "Red";

WriteLine($"Your car is named {car1.PetName}? That's odd...");
WriteLine("------------------------------------------------");
car1.DisplayStats();
