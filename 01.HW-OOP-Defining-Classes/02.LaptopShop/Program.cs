using System;

class Program
{
    static void Main()
    {
        Laptop laptopLenovo = new Laptop("Lenovo Yoga 2 Pro", 2259.00m, new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5));
        laptopLenovo.Manufacturer = "Lenovo";
        laptopLenovo.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
        laptopLenovo.Ram = 8;
        laptopLenovo.GraphicCard = "Intel HD Graphics 4400";
        laptopLenovo.Hdd = 128;
        laptopLenovo.Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";

        Laptop laptopHP = new Laptop("HP 250 G2", 699.00m, new Battery());

        Console.WriteLine(laptopLenovo);
        Console.WriteLine(laptopHP);
    }
}

