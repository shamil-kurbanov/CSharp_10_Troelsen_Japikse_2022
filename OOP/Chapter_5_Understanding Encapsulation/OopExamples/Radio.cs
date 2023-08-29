using System;
using static System.Console;

namespace OopExamples
{
    public class Radio
    {
        // A radio has a volume level
        public void Power(bool TurnOn){
            WriteLine($"Radio on: {TurnOn}");
        }
    }
}