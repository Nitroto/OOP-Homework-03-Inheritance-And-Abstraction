using System;
using System.Text;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double workHours, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHours;
            this.WeekSalary = weekSalary;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("weekSalary", "Week salary cannot be negative!");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("workHoursPerDay", "Work hours per day cannot be negative or greater than 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            if (this.WorkHoursPerDay == 0)
            {
                return 0;
            }
            decimal rate = this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5);
            return rate;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} - Worker  - {1:F2}", base.ToString(), this.MoneyPerHour()));
            return output.ToString();
        }
    }
}
