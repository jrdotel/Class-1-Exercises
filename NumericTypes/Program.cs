using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            string input;

            //! Length of the rectangle//
            Console.WriteLine("Enter the length of the rectangle: ");
            input = Console.ReadLine();
            length = double.Parse(input);

            //! Width of the rectangle//
            Console.WriteLine("Enter the width of the rectangle: ");
            input = Console.ReadLine();
            width = double.Parse(input);

            //! Logs the result
            Console.WriteLine("The area of the rectangle is: " + (length * width));
        }
    }
}
