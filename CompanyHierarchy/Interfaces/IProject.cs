using System;
using CompanyHierarchy.Project;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string ProjectName { get; }
        DateTime ProjectStartDate { get; }
        string Details { get; }
        ProjectState State { get; }
        void CloseProject();
    }
}
