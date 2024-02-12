using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a real number
        Console.Write("Enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Define the intervals
        double interval1Start = 2;
        double interval1End = 3;
        double interval2Start = 0;
        double interval2End = 1;
        double interval3Start = -10;
        double interval3End = -2;

        // Test membership using only < and ==
        bool condition1 = (x >= interval1Start) && (x < interval1End);
        bool condition2 = (x > interval2Start) && (x <= interval2End);
        bool condition3 = (x >= interval3Start) && (x <= interval3End);

        // Display the result based on logical operators
        if (((condition1 || condition2) || (condition3)))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}
