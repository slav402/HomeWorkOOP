
using System;

public class Dog : Animals, ISoundProducible
{
    public Dog(string name, int age, string gender) : base(name, age, gender)
    {
        
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Bau, Bau ...");
    }
}

