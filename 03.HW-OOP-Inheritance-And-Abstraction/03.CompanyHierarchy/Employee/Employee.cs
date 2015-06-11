
public abstract class Employee : Person
{
    public Employee(int id, string nameFirst, string nameLast, int salary, string department)
        : base(id, nameFirst, nameLast)
    {
        this.Salary = salary;
        this.Department = department;
    }

    public int Salary { get; set; }
    public string Department { get; set; }
}

