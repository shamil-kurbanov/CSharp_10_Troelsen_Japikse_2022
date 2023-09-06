using System;
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

//Make readonly Point after construction
PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20, 20);
firstReadOnlyPoint.DisplayStats();

//Or make a point using object init syntax
PointReadOnlyAfterCreation secontReadOnlyPoint = new PointReadOnlyAfterCreation{X = 30, Y = 30};
secontReadOnlyPoint.DisplayStats();

//Calling a custom constructor
Point pt = new Point(10, 16){X = 150, Y = 150}; //Calls ctor, then sets X/Y
//first 10,16 are passed to ctor, then X/Y are set to 150
pt.DisplayStats();

//Calling a more interesting custom constructor with init syntax
Point goldPoint = new Point(PointColorEnum.LightBlue){X = 90, Y = 20};
goldPoint.DisplayStats();

WriteLine();

//Create and initialize a Rectangle
Rectangle myRect = new Rectangle
{
    TopLeft = new Point{X = 10, Y = 10},
    BottomRight = new Point{X = 200, Y = 200}
};

myRect.DisplayStats();

WriteLine();

//Create and initialize a Rectangle
//Old-school approach
Rectangle rectangle = new Rectangle();
Point point1 = new Point(PointColorEnum.LightBlue);
point1.X = 10;
point1.Y = 10;
rectangle.TopLeft = point1; //Set TopLeft property

Point point2 = new Point(PointColorEnum.Gold);
point2.X = 200;
point2.Y = 200;
rectangle.BottomRight = point2; //Set BottomRight property


rectangle.DisplayStats();
