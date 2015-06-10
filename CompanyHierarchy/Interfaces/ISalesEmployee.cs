using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    interface ISalesEmployee : IEmployee
    {
        List<ISale> Sales { get; }
    }
}
