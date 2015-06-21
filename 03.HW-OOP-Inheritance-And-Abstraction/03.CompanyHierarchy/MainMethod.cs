
using System;
using System.Collections.Generic;

class MainMethod
{
    static void Main()
    {
        Manager manager1 = new Manager(9012, "Maria", "Ivanova", 3080, Department.Marketing);
        Manager manager2 = new Manager(1236, "Ivan", "Ivanov", 2010, Department.Accounting);
        Manager manager3 = new Manager(1789, "Pepi", "Popov", 1800, Department.Accounting);
        Manager manager4 = new Manager(6432, "Zlati", "Zlatev", 2000, Department.Accounting);

        Product mobilePhone = new Product("Samsung S6", DateTime.Today, 530);
        Product gadget = new Product("Mini Pad", DateTime.Today, 45);
        Product gadget1 = new Product("Cable", DateTime.Today, 20);

        SalesEmployee employee1 = new SalesEmployee(3490, "Emo", "Cholakov", 890, Department.Sales);
        employee1.SalesList.Add(mobilePhone);
        SalesEmployee employee2 = new SalesEmployee(3490, "Margarita", "Maneva", 795, Department.Sales);
        employee2.SalesList.Add(gadget);
        employee2.SalesList.Add(gadget1);

        Developer develop1 = new Developer(9087, "Mincho", "Draganov", 600, Department.Production);
        Project proj1 = new Project("New car electonic", new DateTime(2004, 12, 4), "Change software to ver2.2");
        proj1.CloseProject();
        develop1.AddProject(proj1);

        var allEmployees = new List<Employee>();
        allEmployees.Add(manager1);
        allEmployees.Add(manager2);
        allEmployees.Add(manager3);
        allEmployees.Add(manager4);
        allEmployees.Add(employee1);
        allEmployees.Add(employee2);
        allEmployees.Add(develop1);

        foreach (var employee in allEmployees)
        {
            Console.WriteLine(employee);
        }
    }
}

