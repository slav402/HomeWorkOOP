    class Customer : Person, ICustomer
    {
        private decimal newAmount;

        public Customer(int id, string firstName, string lastName, decimal netAmount)
            : base(id, firstName, lastName)
        {
            this.Amount = netAmount;
        }

        public decimal Amount { get; set; }

        public void AddAmount(decimal newAmount)
        {
            this.Amount += newAmount;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - ID: {2}, Net amount:{3}", this.FirstName, this.LastName, this.ID, this.Amount);
        }
    }
