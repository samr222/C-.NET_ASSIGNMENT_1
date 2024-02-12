using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a real number
        Console.Write("Enter a real number: ");

        double x = double.Parse(Console.ReadLine());

        // Define the intervals
        double interval1_1 = 2;
        double interval1_2 = 3;
        double interval2_1 = 0;
        double interval2_2 = 1;
        double interval3_1 = -10;
        double interval3_2 = -2;

        // Test membership using only < and ==
        bool condt1 = (x >= interval1_1) && (x < interval1_2);
        bool condt2 = (x > interval2_1) && (x <= interval2_2);
        bool condt3 = (x >= interval3_1) && (x <= interval3_2);

        // Display the result based on logical operators
        if (((condt1 || condt2) || (condt3)))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}
