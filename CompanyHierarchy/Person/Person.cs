using System;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Person
{
    abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("id", "ID cannot be a negative number.");
                }

                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("firstName", "First name connot be empty or null!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("lastName", "Last name connot be empty or null!");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("ID: {0}{3}Name: {1} {2}{3}", this.Id, this.FirstName, this.LastName, Environment.NewLine));
            return output.ToString();
        }
    }
}
