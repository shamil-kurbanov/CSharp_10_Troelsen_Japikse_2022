using System;
using static System.Console;

namespace Data_Types;

public static class CharOperations{
    public static void CharFunctionality(){
        WriteLine("=> Char type Functionality:");
        char myChar = 'a';
        WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
        WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
        //wird überprüft, ob das Zeichen an Index 5 im String "Hello There" ein Leerzeichen ist.
        WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
        WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        WriteLine();

    }
}