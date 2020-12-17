using System;
using System.Globalization;

namespace Excercises
{
    class Excercise2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Month number:");
            Console.Write(DateTimeFormatInfo.CurrentInfo.GetMonthName(Int32.Parse(Console.ReadLine())));
        }
    }
}


