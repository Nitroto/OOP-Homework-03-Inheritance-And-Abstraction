using System;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Project
{
    class Project : IProject
    {
        private string projectName;

        public Project(string projectName, DateTime projectStartDate, ProjectState projectState, string details = null)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.State = projectState;
            this.Details = details;
        }
        public Project(string projectName, string details = null):this(projectName,DateTime.Now,ProjectState.Open, details)
        {
        }
        public Project(string projectName,ProjectState state, string details = null):this(projectName,DateTime.Now, state, details)
        {
        }
        public Project(string projectName, DateTime projectStartDate, string details = null) : this(projectName, projectStartDate, ProjectState.Open, details)
        {
        }

        public string Details { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public ProjectState State { get; private set; }
        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("projectName", "Project name cannot be empty or null!");
                }
                this.projectName = value;
            }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("- {0} - {1} - {2} - {3}", this.ProjectName, this.Details ?? "no details", this.ProjectStartDate, this.State));
            return output.ToString();
        }

    }
}
