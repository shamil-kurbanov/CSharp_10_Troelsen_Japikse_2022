using System;
using static System.Console;

namespace SimpleCSharpApp;


class Program
{
    public static void Main(string[] args)
    {
        Title = "Property of System. User: " + Environment.UserName;

        WindowHeight = 40;
        WindowWidth = 40;
        

        // Display a simple message to the user.
        WriteLine("***** My First C# App *****");
        WriteLine("Hello World!");
        WriteLine();

        TopLevelStatements(); //Call the local method

        //Local method within the Top-level statements
        ShowEnvirontmentDetails();


        //Local method within the TopLevelStatements method
        static void TopLevelStatements()
        {
            WriteLine("***** Top-Level Statements *****");
            WriteLine("The Main() method is not the entry point of the program!");
            WriteLine("The entry point is the first statement in the file having the 'Main' attribute.");
            WriteLine();
        }


        // Wait for Enter key to be pressed before shutting down.
        ReadLine();
    }

    static void ShowEnvirontmentDetails()
    {
       //Print out the drives on this machine, and other interesting details.
       foreach (string drive in Environment.GetLogicalDrives())
        {
              WriteLine($"Drive: {drive}");
            //Insgesamt Größe der Festplatte in Gb
            WriteLine($"Free space: {new System.IO.DriveInfo(drive).TotalFreeSpace / 1024 / 1024 / 1024} Gb");
                WriteLine($"Format: {new System.IO.DriveInfo(drive).DriveFormat}");
                WriteLine($"Type: {new System.IO.DriveInfo(drive).DriveType}");
                WriteLine($"Name: {new System.IO.DriveInfo(drive).Name}");
                WriteLine($"Root Directory: {new System.IO.DriveInfo(drive).RootDirectory}");
                WriteLine($"Volume Label: {new System.IO.DriveInfo(drive).VolumeLabel}");
                WriteLine();
         }

       WriteLine($"OS: {Environment.OSVersion}"); //Betriebssystem
        //ist das windows 11?
        WriteLine($"Is 64-Bit OS: {Environment.Is64BitOperatingSystem}");
        //WIndows 7, 10 or 11?

        //if Os is windows 11
        if (Environment.OSVersion.Version.Major == 10 && Environment.OSVersion.Version.Minor == 0 && Environment.OSVersion.Version.Build >= 22000)
        {
            WriteLine("Windows 11");
        }

        //if Os is windows 10
        if (Environment.OSVersion.Version.Major == 10 && Environment.OSVersion.Version.Minor == 0 && Environment.OSVersion.Version.Build < 22000)
        {
            WriteLine("Windows 10");
        }

        WriteLine($"Number of processors: {Environment.ProcessorCount}"); //Anzahl der Prozessoren
        WriteLine($"Name of Machine: {Environment.MachineName}"); //MachineName
        WriteLine($"UserName: {Environment.UserName}"); //UserName
        WriteLine($"");

        WriteLine($".NET Version: {Environment.Version}"); // .NET Version
        WriteLine();
        WriteLine($"Version.Major: {Environment.Version.Major}"); //Version.Major
        WriteLine($"Version.Minor: {Environment.Version.Minor}"); //Version.Minor
        WriteLine($"Version.Build: {Environment.Version.Build}"); //Version.Build
        WriteLine($"");

        WriteLine($".NET Version: {Environment.Version}"); // .NET Version
        WriteLine();
        WriteLine($"Current Directory: {Environment.CurrentDirectory}"); //CurrentDirectory

        Beep();


    }
}