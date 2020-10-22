using System;

namespace polymorphism
{
    class Animal
    {
        public void MakeAnimalSound()
        {
            Console.WriteLine("Making animal sounds");
        }
    }

    class Cat : Animal
    {
        public void MakeAnimalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}