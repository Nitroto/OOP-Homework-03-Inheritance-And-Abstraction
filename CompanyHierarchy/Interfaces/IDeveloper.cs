using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper:IEmployee
    {
        List<IProject> Projects { get; }
    }
}
