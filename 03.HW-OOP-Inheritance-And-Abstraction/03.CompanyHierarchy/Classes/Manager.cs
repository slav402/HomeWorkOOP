using System.Collections.Generic;

class Manager : Employee, IManager
{
    List<Employee> employeesUnderComand = new List<Employee>();

    public Manager(int id, string nameFirst, string nameLast, decimal salary, Department department) : base(id, nameFirst, nameLast, salary, department)
    {
        
    }

    public void AddEmployee(Employee employee)
    {
        employeesUnderComand.Add(employee);
    }

    public override string ToString()
    {
        return base.ToString() + "\nEmployee under command:" + string.Join(", ", employeesUnderComand);
    }
}

