using System;
using static System.Console;

namespace ObjectInitializers;

public class Rectangle
{
    private Point topLeft = new Point();
    private Point bottomRight = new Point();

    public Point TopLeft
    {
        get => topLeft;
        set => topLeft = value;
    }

    public Point BottomRight
    {
        get => bottomRight;
        set => bottomRight = value;
    }

    public void DisplayStats()
    {
        WriteLine("Rectange Info:");
        WriteLine($"[TopLeft: {topLeft.X}, {topLeft.Y}, {topLeft.Color} \n" +
         $"BottomRight: {bottomRight.X}, {bottomRight.Y}, {bottomRight.Color}]");
    }

}