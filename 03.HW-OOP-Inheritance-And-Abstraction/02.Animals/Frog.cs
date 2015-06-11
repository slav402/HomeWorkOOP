
using System;

public class Frog : Animals, ISoundProducible
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
        
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Pras, Pras ....");
    }
}

