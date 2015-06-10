using System;

namespace CompanyHierarchy.Interfaces
{
    class ISale
    {
        string ProductName { get; }
        DateTime Date { get; }
        decimal Price { get; }
    }
}
