using CompanyHierarchy.Person;

namespace CompanyHierarchy.Interfaces
{
    interface IEmployee : IPerson
    {
        Department Department { get; }
        decimal Salary { get; }
    }
}
