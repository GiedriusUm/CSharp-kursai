using System;
namespace Excercises
{
    class Excercise1
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter String:"); 
            var inputString=Console.ReadLine();
            Console.Write(inputString[0]+inputString+inputString[0]);
        }
    }
}