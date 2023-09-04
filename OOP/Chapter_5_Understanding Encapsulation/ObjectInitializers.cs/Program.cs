﻿using System;
using static System.Console;
using ObjectInitializers;

WriteLine("***** Fun with Object Init Syntax *****\n");
//Make a Point by setting each property manually
Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

//Or make a Point via a custom constructor
Point anotherPoint = new Point(20, 20);
anotherPoint.DisplayStats();

//Or make a Point using object init syntax
Point finalPoint = new Point{X = 30, Y = 30};
finalPoint.DisplayStats();