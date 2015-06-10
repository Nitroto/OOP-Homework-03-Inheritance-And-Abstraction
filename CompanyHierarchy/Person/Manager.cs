using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyHierarchy.Interfaces;
using System;

namespace CompanyHierarchy.Person
{
    class Manager : Employee, IManager
    {
        private List<IEmployee> staff;

        public Manager(string firstName, string lastName, int id, decimal salary, Department department, List<IEmployee> staff)
            : base(firstName, lastName, id, salary, department)
        {
            this.Staff = staff;
        }
        public Manager(string firstName, string lastName, int id, decimal salary, Department department, IEmployee employee)
            :this(firstName, lastName, id, salary, department,new List<IEmployee> {employee })
        { }

        public List<IEmployee> Staff { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format("Manager of Department {0}{1}", this.Department, Environment.NewLine));
            output.Append(string.Format("Managed employees - {0}{1}", this.Staff.Count, Environment.NewLine));
            foreach (IEmployee employee in this.Staff)
            {
                output.Append(string.Format("-ID: {0} Name: {1} {2}", employee.Id, employee.FirstName, employee.LastName));
            }
            return output.ToString();
        }
    }
}
