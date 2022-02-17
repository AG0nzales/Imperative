using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        // Here we declare an integer array with numbers 
        // the numbers inside this array will be then be summed
        int[] arr = { 1, 2, 5, 10, 12, 15, 99 };
        
 
        // Here we create a for loop that will iterate inside the array
         for (int i = 0; i < arr.Length; i++){
             
            //  everytime it iterates the Array
            // it will go inside this conditional statement to asses either if its true or false
            if(arr[i] < 10){
                Console.WriteLine(arr[i]);
            }
        }
        
    }
    }
