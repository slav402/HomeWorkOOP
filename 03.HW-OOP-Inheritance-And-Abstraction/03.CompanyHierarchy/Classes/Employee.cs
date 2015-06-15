
public abstract class Employee : Person, IEmployee
{
    public Employee(int id, string nameFirst, string nameLast, decimal salary, Department department)
        : base(id, nameFirst, nameLast)
    {
        this.Salary = salary;
        this.Department = department;
    }

    public decimal Salary { get; set; }
    public Department Department { get; set; }

    public override string ToString()
    {
        return base.ToString()+ "\n" +string.Format("Department: {0}, Salary: {1} BGN", this.Department, this.Salary);
    }
}

