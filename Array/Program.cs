/*
 Author: Bethy Gomez
 Date: 9/15/2019
 Description: Class Project - Deliverable 3 - Arrays
 */

using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Output comes out in a different color

            int[] array = new int[25]; // Auto populated array; This specifies an array of 25 integers

            for (int i = 0; i < 25; i++) 
            {
                array[i] = i + 1; // To begin the array at 1
            } // End of for loop
           
            foreach (int number in array) // Foreach loop to display the array
            {
                int i = number;
                Console.WriteLine("Element value = {1}", i, number);                 
            } // End of foreach
           
            // To pause before closing the program
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
            
        } // End of Main
    } // End of class
} // End of namespace
