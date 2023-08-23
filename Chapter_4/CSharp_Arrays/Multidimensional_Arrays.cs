using System;
using static System.Console;

namespace CSharp_Arrays;

public static class Multidimensional_Arrays
{
    //first type of multidimensional array
    public static void RectMultidimensionalArray()
    {
        WriteLine("=> Rectangular multidimensional array");
        //A rectangular MD array
        int[,] myMatrix = new int[3,4]; //3x4 array
        //Populate (3 * 4) array
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                myMatrix[i, j] = i * j;
            }
        }

        /*
        
        i\j | 0 | 1 | 2 | 3
        ---------------------
         0  | 0 | 0 | 0 | 0
         1  | 0 | 1 | 2 | 3
         2  | 0 | 2 | 4 | 6

        */

        //Print (3 * 4) array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Write(myMatrix[i, j] + "\t");
            }
            WriteLine();
        }
        WriteLine();

        WriteLine("Rank of myMatrix: {0}D", myMatrix.Rank); //Rank of myMatrix: 2


    }

    //second type of multidimensional array
    /*
     * The second type of multidimensional array is termed a jagged array.
     * As the name implies, jagged arrays contain some number of inner arrays,
     * each of which may have a differen upper limit. Here is an example:
     */
    public static void JaggedMultidimensionalArray()
    {
        WriteLine("=> Jagged multidimensional array");
        //A jagged MD array (i.e., an array of arrays)
        //Hier we have an array of 5 different arrays
        int[][] myJagArray = new int[5][];


        //Create the jagged array
        for (int i = 0; i < myJagArray.Length; i ++)
        {
            myJagArray[i] = new int[i + 7];
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < myJagArray[i].Length; j++)
            {
                Write(myJagArray[i][j] + " ");
            }
            WriteLine();
        }
        WriteLine();

        WriteLine("Rank of myJagArray: {0}D", myJagArray.Rank); //Rank of myJagArray: 1

        //This is a count of the number of elements in the first dimension
        WriteLine("The count of the number of elements in the first dimension: ");
        WriteLine(myJagArray[0].Length); 
    }

    /*
     * 
     * Let�s see some of these members in action. The following helper method makes use 
     * of the static Reverse() and Clear() methods to pump out information about an array 
     * of string types to the console:
     * 
     */

    public static void SystemArrayFunctionality()
    {
        WriteLine("=> Working with System.Array");
        //Initialize items at startup

        string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};

        //Print out names in declared order
        WriteLine("-> Here is the array:");
        for(int i = 0; i < gothicBands.Length; i++)
        {
            //Print a name
            Write(gothicBands[i] + ", ");
        }
        WriteLine("\n");

        //Reverse them...
        Array.Reverse(gothicBands);
        WriteLine("-> The reversed array");
        //...and print them
        for(int i = 0; i < gothicBands.Length; i++)
        {
            //Print a name
            Write(gothicBands[i] + ", ");
        }
        WriteLine("\n");

        //Clear out all but the first member
        WriteLine("-> Cleared out all but one...");
        Array.Clear(gothicBands, 1, 2); //Clear out all but the first member
        for(int i = 0; i < gothicBands.Length; i++)
        {
            //Print a name
            Write(gothicBands[i] + ", ");
        }
        WriteLine();

        ReadLine();
    }
}