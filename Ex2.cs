using System;
using System.Globalization;

namespace Excercises
{
    class Excercise2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Month number:");
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            Console.Write(dtfi.GetMonthName(Int32.Parse(Console.ReadLine())));
        }
    }
}
