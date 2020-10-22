using System;

namespace polymorphism
{
    class Animal
    {
        public virtual void MakeAnimalSound()
        {
            Console.WriteLine("Making animal sounds");
        }
    }

    class Cat : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Llama : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Honk");
        }
    }
}