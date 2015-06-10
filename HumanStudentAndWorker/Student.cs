using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private const string FacultyNumberFormat = @"[\d\w]{5,10}";
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (!Regex.IsMatch(value, FacultyNumberFormat))
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", "Faculty number should be 5-10 digits or letters!");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} - Student  - {1}", base.ToString(), this.FacultyNumber));
            return output.ToString();
        }
    }
}
