using System;

namespace yt_challange._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            double num03;

            Console.WriteLine ("Write a number here: ");
            num01 = Convert.ToDouble(Console.ReadLine() );

            Console.WriteLine ("Write a second number here: ");
            num02 = Convert.ToDouble(Console.ReadLine() );

            Console.WriteLine ("Write a third number here: ");
            num03 = Convert.ToDouble(Console.ReadLine() );

            double result = (num01 + num02 + num03) / 3;

            Console.WriteLine ("The result is " + result);


            Console.ForegroundColor = ConsoleColor.Black;
           


        }
    }
}
