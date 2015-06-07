using System;

class Persons
{
    static void Main()
    {
        var p = new Person("Pesho", 32, "pe60@yahoo.com");
        var g = new Person("Gosho", 19);

        Console.WriteLine(p); 
        Console.WriteLine(g);
    }
}

