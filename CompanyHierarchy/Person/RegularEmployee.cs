namespace CompanyHierarchy.Person
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName, string lastName, int id, decimal salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
        }
    }
}
