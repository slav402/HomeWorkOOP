using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student("Ivan", "Ivanov", 0300),
            new Student("Petia", "Stefanowa", 8201),
            new Student("Stefan", "Petrow", 1702),
            new Student("Pavel", "Slavov", 3803),
            new Student("Rumen", "Pavlow", 2404),
            new Student("Tatiqna", "Momchilova", 1605),
            new Student("Maria", "Ivanova", 1046),
            new Student("Kristina", "Dafinova", 4507),
            new Student("Ivan", "Kolev", 6608),
            new Student("Radostina", "Zekova", 9079),
        };
        var orderedStudentList = new List<Student>(studentList.OrderBy(x => x.FacultyNumber));

        foreach (var student in orderedStudentList)
        {
            Console.WriteLine(student);
        }


        List<Worker> workerList = new List<Worker>()
        {
            new Worker("Ivan", "Germanov", 240.50m, 8),
            new Worker("Kiril", "Petrov", 326.67m, 4),
            new Worker("Vasil;", "Kuzev", 508.19m, 8),
            new Worker("Evgeni", "Emilow", 189.98m, 6),
            new Worker("Irina", "Koceva", 450.40m, 8),
            new Worker("Katia", "Peneva", 123.88m, 6),
            new Worker("Eva", "Germanova", 456.19m, 8),
            new Worker("Stoian", "Soianov", 516.33m, 10),
            new Worker("Gergana", "Emilowaa", 218.99m, 12),
            new Worker("Yordan", "Gerov", 500.00m, 8),
        };

        var lsitWorker = new List<Worker>(workerList.OrderBy(w => w.MoneyPerHour()));
        foreach (var worker in lsitWorker)
        {
            Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker);
        }
        Console.WriteLine();

        List<Human> allHumans = new List<Human>();

        studentList.ForEach(student => allHumans.Add(student));
        lsitWorker.ForEach(worker => allHumans.Add((worker)));

        allHumans = new List<Human>(allHumans.OrderBy(a => a.FirstName));
        foreach (var human in allHumans)
        {
            Console.WriteLine(human.FirstName + " " + human.LastName + " - " + human.GetType().Name);
        }
    }
}

