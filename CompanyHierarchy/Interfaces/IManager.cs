using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    interface IManager : IEmployee
    {
        List<IEmployee> Staff { get; }
    }
}
