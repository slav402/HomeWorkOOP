
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class Computer
{
    private string name;
    private List<Components> components;

    public string Name {
        get
        {
            return this.name; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            this.name = value;
        }
    }
    public List<Components> Components 
    {
        get
        {
            return this.components;            
        }
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentNullException("Computer muste have a components");
            }
            this.components = value;
        }
    }

    public decimal Price {
        get { return Calculate(this); }
    }

    public Computer(string name, List<Components> components)
    {
        this.Name = name;
        this.Components = components;
    }

    private decimal Calculate(Computer computer)
    {
        var component = computer.Components;
        decimal price = component.Sum(copmponent => copmponent.Price);

        return price;
    }

    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
        StringBuilder result = new StringBuilder();
        result.AppendLine(string.Format("Computer name: {0}", this.Name));
        foreach (var component in Components)
        {
            result.AppendLine(string.Format("{0} ({1}) - {2:C2}", component.Name, string.IsNullOrWhiteSpace(component.Details) ? "x" : component.Details, component.Price));
        }
        result.AppendLine(string.Format("Tottal price: {0:C2}", this.Price));

        return result.ToString();
    }



}

