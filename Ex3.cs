using System;

namespace Excercises
{
    class Excercise3
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter String:"); 
         string reversestring = ""; 
         int length; 
         var stringInput=Console.ReadLine(); 
         length = stringInput.Length - 1; 
         while (length >= 0){ 
    	    reversestring = reversestring + stringInput[length]; 
    	    length--; 
         } 
         Console.WriteLine(reversestring); 
        }
    }
}
