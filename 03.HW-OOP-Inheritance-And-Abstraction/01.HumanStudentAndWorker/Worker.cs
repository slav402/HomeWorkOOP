
using System;

class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;
    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary { get; set; }
    public int WorkHoursPerDay { get; set; }
   
    internal decimal MoneyPerHour()
    {
        return this.WeekSalary / this.WorkHoursPerDay;
    }

    public override string ToString()
    {
        return String.Format("{0}, week salary:{1}, work hour per day:{2}, money per hour:{3}", base.ToString(), WeekSalary, WorkHoursPerDay, this.MoneyPerHour());
    }
}

