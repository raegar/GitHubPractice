using System;
using System.Collections.Generic;

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

            // Animal section

            List<Animal> animals = new List<Animal>();

            Animal animal = new Animal();
            Animal cat = new Cat();
            Animal llama = new Llama();

            animals.Add(animal);
            animals.Add(cat);
            animals.Add(llama);

            foreach(Animal a in animals)
            {
                a.MakeAnimalSound();
            }


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
