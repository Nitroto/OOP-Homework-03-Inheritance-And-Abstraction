﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Person
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Department department, List<ISale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }
        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Department department, ISale sale)
            : this(firstName, lastName, id, salary, department, new List<ISale> { sale })
        {
        }

        public List<ISale> Sales { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format("Sales Employee{0}Sales made: {1}", Environment.NewLine, this.Sales.Count));
            return output.ToString();
        }
    }
}
