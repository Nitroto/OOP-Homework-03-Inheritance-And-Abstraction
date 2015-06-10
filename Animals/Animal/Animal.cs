using Animals.Interfaces;
using System;

namespace Animals
{
    abstract class Animal: ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty or null!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be negative!");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("gender", "Gender should be male or female!");
                }
                this.gender = value;
            }
        }

        public virtual void ProduceSound()
        {
        }
    }
}
