using System;
using static System.Console;

namespace Data_Types;


public static class SwitchOperations
{
    public static void SwitchExample(){
        WriteLine("1 [c#]], 2 [VB]");
        Write("Please pick your language preference: ");

        string langChoice = ReadLine();
        int n = int.Parse(langChoice);

        switch(n)
        {
            case 1:
                WriteLine("Good choice, C# is a fine language.");
                break;
            case 2:
                WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                WriteLine("Well ... good luck with that!");
                break;

        }
    }
    
    //This method is the same as SwitchExample() but uses a string 
    //instead of an int
    public static void SwitchOnStringExample(){
        WriteLine("C# or VB");
        Write("Please pick your language preference: ");

        string langChoice = ReadLine();
        switch(langChoice.ToUpper()){
            case "C#":
                WriteLine("Good choice, C# is a fine language.");
                break;
            case "VB":
                WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                WriteLine("Well ... good luck with that!");
                break;
        }
    }

    //This method is the same as SwitchExample() but uses an enum
    public static void SwitchOnEnumExample(){
        Write("Enter your favorite day of the week: ");
        DayOfWeek favDay;
        try{
            favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), ReadLine());
        } catch(Exception){
            WriteLine("Bad input!");
            return;
        }

        switch(favDay){
            case DayOfWeek.Sunday:
                WriteLine("Football!!");
                break;
            case DayOfWeek.Monday:
                WriteLine("Another day, another dollar");
                break;
            case DayOfWeek.Tuesday:
                WriteLine("At least it is not Monday");
                break;
            case DayOfWeek.Wednesday:
                WriteLine("A fine day.");
                break;
            case DayOfWeek.Thursday:
                WriteLine("Almost Friday...");
                break;
            case DayOfWeek.Friday:
                WriteLine("Yes, Friday rules!");
                break;
            case DayOfWeek.Saturday:
            //case DayOfWeek.Sunday:
                WriteLine("Great day indeed.");
                break;
        }
        WriteLine();
    }


    public static void ExecutePatternMatchingSwitch(){
        WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
        Write("Please choose an option: ");

        string userChoice = ReadLine();
        object choice;

        //This is a standart pattern switch statement to set up the example
        switch(userChoice){
            case "1":
                choice = 5;
                break;
            case "2":
                choice = "Hi";
                break;
            case "3":
                choice = 2.5M;
                break;
            default:
                choice = 5;
                break;
        }
        //This is new the pattern matching switch statement
        switch(choice){
            case int i:
                WriteLine("Your choice is an integer {0}", i);
                break;
            case string s:
                WriteLine("Your choice is a string {0}", s);
                break;
            case decimal d:
                WriteLine("Your choice is a decimal {0}", d);
                break;
            default:
                WriteLine("Your choice is something else. {0}", choice.GetType().Name);
                break;
        }

        WriteLine();
    }

    public static void ExecutePatternMatchingSwitchWithWhen(){
        WriteLine("1 [C#], 2 [VB]");
        Write("Please pick your language preference: ");

        object langChoice = ReadLine();
        var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

        switch(choice){
            case int i when i == 2:
            case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                WriteLine("VB: OOP, multithreading, and more!");
                break;
            case int i when i == 1:
            case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                WriteLine("Good choice, C# is a fine language.");
                break;
            default:
                WriteLine("Well ... good luck with that!");
                break;
        }
        WriteLine();
    }

    //This FromRainbowClassic() method take a string and returns a string
    public static string FromRainbowClassic(string colorBand){
        switch(colorBand){
            case "Red":
                return "FF0000"; //Red
            case "Orange":
                return "FF7F00"; 
            case "Yellow":
                return "FFFF00";
            case "Green":
                return "00FF00";
            case "Blue":
                return "0000FF";
            case "Indigo":
                return "4B0082"; 
            case "Violet":
                return "9400D3";
            default:
                return "FFFFFF"; //White
        }
    }

    public static string RockPaperScissors(string first, string second){
        return (first, second) switch{
            ("rock", "paper") => "Paper wins",
            ("rock", "scissors") => "Rock wins",
            ("paper", "rock") => "Paper wins",
            ("paper", "scissors") => "Scissors wins",
            ("scissors", "rock") => "Rock wins",
            ("scissors", "paper") => "Scissors wins",
            (_, _) => "Tie",
        };
    }
}