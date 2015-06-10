using System;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Person
{
    class Customer : Person, ICustomer
    {
        private decimal spendingAmount;
        public Customer(string firstName, string lastName, int id, decimal spendingAmount)
            :base(firstName,lastName,id)
        {
        }

        public decimal SpandingAmount
        {
            get { return this.spendingAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("spendingAmount", "The spending amount cannot be negative!");
                }
                this.spendingAmount = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format("Customer{0}Spended Amount: {1:C2}", Environment.NewLine, this.SpandingAmount));
            return output.ToString();
        }
    }
}
