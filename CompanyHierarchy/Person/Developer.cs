using System;
using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Person
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string firstName, string lastName, int id, decimal salary, Department department, List<IProject> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }
        public Developer(string firstName, string lastName, int id, decimal salary, Department department, IProject project)
            : this(firstName, lastName, id, salary, department, new List<IProject> { project })
        {
        }

        public List<IProject> Projects { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format("Developer{0}Projects: {1}{0}", Environment.NewLine, this.Projects.Count));
            foreach (var project in this.Projects)
            {
                output.Append(project.ToString());
            }
            return output.ToString();
        }
    }
}
