    using System;

public abstract class Cat : Animals, ISoundProducible
    {
        protected Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau, Miau ...");
        }
    }

