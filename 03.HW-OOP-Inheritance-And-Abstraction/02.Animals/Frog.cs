
using System;

public class Frog : Animals, ISoundProducible
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
        
    }

    public override string ToString()
    {
        return string.Format("{0}\nName: {1}\nAge: {2}\nGender: {3}", GetType(), this.Name, this.Age, this.Gender);
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Pras, Pras ....");
    }
}

