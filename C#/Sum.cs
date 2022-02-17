using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        // Here we declare an integer array with numbers 
        // the numbers inside this array will be then be summed
        int[] array = { 1, 2, 5, 10, 12, 15, 99 };
 
        // Here we declare an int variable named sum
        // that variable will hold the logic of summing up all
        // elements inside the array using the .Sum function of C#
        int sum = array.Sum();
        
        // Here we print the result of the logic 
        // inside the variable sum
        Console.WriteLine(sum);
    }
}