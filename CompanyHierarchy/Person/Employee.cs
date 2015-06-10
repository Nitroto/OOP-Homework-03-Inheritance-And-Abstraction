using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Person
{
    abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(string firstName, string lastName, int id, decimal salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be negative!");
                }
                this.salary = value;
            }
        }
        public Department Department { get; set; }
    }
}
