
using System;

class Components
{
    public string name;
    public decimal price;

    public string Name
    {
        get
        {
            return this.name; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name of the components cannot be empty!");
            }
            this.name = value;
        }

    }
    public decimal Price {
        get
        {
            return this.price; 
            
        }
        set
        {
            if (value < 0 )
            {
                throw new ArgumentException("The price cannot be negative!");
            }
            this.price = value;
        }
    }

    public string Details { get; set; }

    public Components(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Components(string name, decimal price, string details) : this(name, price)
    {
        this.Details = details;
    }
}

