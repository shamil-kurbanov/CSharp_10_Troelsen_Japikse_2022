using System;
using static System.Console;
using static Data_Types.DataTypeOperations;
using static Data_Types.CharOperations;
using static Data_Types.ParseOperations;
using static Data_Types.DatesAndTimesOperations;
using static Data_Types.SwitchOperations;

namespace Data_Types
{
    class Program
    {
        public static void Main(string[] args)
        {
            //DataTypeOperations.DataTypeFunctionality();
            //CharOperations.CharFunctionality();
            //ParseOperations.ParseFromStringWithParse();
            //DatesAndTimesOperations.UseDatesAndTimes();
            //SwitchExample();
            //SwitchOnStringExample();
            //SwitchOnEnumExample();
            //ExecutePatternMatchingSwitch();
            //string colorChoice = FromRainbowClassic("Red");
            //WriteLine(colorChoice);
            //RockPaperScissors auf console
            var letters = RockPaperScissors("rock", "paper");
            WriteLine(letters);


        }
    }
}