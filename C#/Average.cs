using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        // Here we declare an integer array with numbers 
        // the numbers inside this array will be then be summed
        int[] arr = { 1, 2, 5, 10, 12, 15, 99 };
        
        // create a variable int sum
        int sum = 0;
 
        // Here we create a for loop that will sum the numbers inside the array
        // that variable will hold the logic of summing up all
        // elements inside the array using the .Sum function of C#
         for (int i = 0; i < arr.Length; i++){
            //  everytime it iterates the Array
            // it will add the next element holding it
            // till the end of the array length
            sum += arr[i];
        }

        // declare a float variable average to hold the average
        // of all the elements inside the array
        float average = (float)sum / arr.Length;
        
        // we print the outpu
        Console.WriteLine(average);
    }
    }
