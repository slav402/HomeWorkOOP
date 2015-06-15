
using System;

class Product
{
    private string productName;
    private DateTime sellDate;
    private decimal price;

    public Product(string productName, DateTime sellDate, decimal price)
    {
        this.Name = productName;
        this.Date = sellDate;
        this.Price = price;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
       return string.Format("Produc name: {0}, Date of sale: {1}, Price {2} BGN", this.Name, this.Date, this.Price);
    }
}

