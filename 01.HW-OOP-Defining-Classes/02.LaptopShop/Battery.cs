using System;

class Battery
{
    private string batteryModel;
    private double batteryLife;

    public Battery()
    {

    }
    public Battery(string batteryModel)
    {
        this.BatteryModel = batteryModel;
    }
    public Battery(double batteryLife)
    {
        this.BatteryLife = batteryLife;
    }
    public Battery(string batteryModel, double batteryLife)
    {
        this.BatteryModel = batteryModel;
        this.BatteryLife = batteryLife;
    }
    
    public string BatteryModel
    {
        get { return this.batteryModel; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Battery model cannot be empty!");
            }
            this.batteryModel = value;
        }
    }
    public double BatteryLife 
    {
        get { return this.batteryLife; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Battery life cannot be less from zero");
            }
            this.batteryLife = value;
        }
    }
}

