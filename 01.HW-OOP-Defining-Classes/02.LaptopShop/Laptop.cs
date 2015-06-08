using System;
using System.Text;

class Laptop
{
    private string model;
    private decimal price;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicCard;
    private int hdd;
    private string screen;

    public Laptop(string model, decimal price) : this(model, price, null)
    {
        
    }

    public Laptop(string model, decimal price, Battery batery)
    {
        this.Model = model;
        this.Price = price;
        this.Batt = batery;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model cannot be empty!");
            }
            this.model = value;
        }
        
    }

    public decimal Price
    {
        get
        {
            return this.price; 
            
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be less from zero!");
            }
            this.price = value;
        }
        
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Manufacturer cannot be empty!");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Processor cannot be empty!");
            }
            this.processor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Ram cannot be empty!");
            }
            this.ram = value;
        }
    }

    public string GraphicCard
    {
        get
        {
            return this.graphicCard; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Graphic card cannot be empty!");
            }
            this.graphicCard = value;
        }

    }

    public int Hdd
    {
        get
        {
            return this.hdd; 
            
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("HDD cannot be less from zero!");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Screen cannot be empty!");
            }
            this.screen = value;
        }
    }
    public Battery Batt { get; set; }

    

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(string.Format("Laptop {0} description", this.Model));
        result.AppendLine("Model: " + this.Model);

        if (manufacturer != null)
        {
            result.AppendLine("Manufacturer: " + this.Manufacturer);
        }
        if (processor != null)
        {
            result.AppendLine("Processor: " + this.Processor);
        }
        if (ram > 0)
        {
            result.AppendLine("RAM: " + this.Ram + " GB");
        }
        if (graphicCard != null)
        {
            result.AppendLine("Grapfic card: " + this.GraphicCard);
        }
        if (hdd > 0)
        {
            result.AppendLine("HDD: " + this.Hdd +" GB SSD");
        }
        if (screen != null)
        {
            result.AppendLine("Screen: "+ this.Screen);
        }
        if (Batt != null)
        {
            if (Batt.BatteryModel != null)
            {
                result.AppendLine("Battery: " + this.Batt.BatteryModel);
            }
            if (Batt.BatteryLife > 0)
            {
                result.AppendLine("Battery Life: " + this.Batt.BatteryLife + "hours");
            } 
        }
        
        result.AppendLine("Price: " + this.Price + "lv");
        return result.ToString();
    }
}

