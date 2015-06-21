
using System.Collections.Generic;

class SalesEmployee : Employee, ISalesEmployee
{
    public IList<Product> salesList;

    public SalesEmployee(int id, string nameFirst, string nameLast, decimal salary, Department department, IList<Product> salesList) : base(id, nameFirst, nameLast, salary, department)
    {
        this.SalesList = salesList;
    }

    public SalesEmployee(int id, string nameFirst, string nameLast, decimal salary, Department department)
        : base(id, nameFirst, nameLast, salary, department)
    {
        this.SalesList = new List<Product>();
    }

    public IList<Product> SalesList
    {
        get { return this.salesList; }
        set { this.salesList = value; }
    }

    public void AddSale(Product product)
    {
        salesList.Add(product);
    }

    public override string ToString()
    {
        return base.ToString() + string.Format("\nSales:\n{0}", string.Join("\n", SalesList));
    }
}

