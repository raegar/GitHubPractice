using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInts = AddTwoNumbers(7, 13);
            double addedSumOfDoubles = AddTwoNumbers(7.5, 13.8);

            Console.WriteLine("Int: " + addedSumOfInts);
            Console.WriteLine("Double: " + addedSumOfDoubles);
        }

        static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static double AddTwoNumbers(double x, double y)
        {
            return x + y;
        }
    }
}
