using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInts = AddTwoInts(7, 13);

            Console.WriteLine("Int: " + addedSumOfInts);
        }

        static int AddTwoInts(int x, int y)
        {
            return x + y;
        }
    }
}
