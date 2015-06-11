
using System;
using System.Linq;

class MainMethod
{
    static void Main()
    {
        Animals[] animals = new Animals[]
        {
            new Tomcat("Leopold", 4, "Male"),
            new Kitten("Fifi", 6, "female"),
            new Dog("Charo", 3, "male"),
            new Frog("Kiko", 2, "male"),
        };
        
        foreach (var animal in animals)
        {
            animal.ProduceSound();
        }

        double averageAge = animals.Average(x => x.Age);
        Console.WriteLine(averageAge);
    }

    
}

