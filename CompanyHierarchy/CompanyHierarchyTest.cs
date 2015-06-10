using System;
using CompanyHierarchy.Person;
using CompanyHierarchy.Project;
using System.Threading;
using System.Globalization;

namespace CompanyHierarchy
{
    class CompanyHierarchyTest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            SalesEmployee saler = new SalesEmployee("Sales", "Emploeey", 10, 500M, Department.Sales, new Sale("product", 50));
            Developer developer = new Developer("Code", "Pisachev", 20, 1500M, Department.Production, new Project.Project("igrica", "first game"));
            Manager manager = new Manager("Boss", "Bossov", 1, 2000M, Department.Sales, saler);



            Employee[] employees =
            {
                saler,
                developer,
                manager,
                new RegularEmployee("Petar","Petrov",1001,400M,Department.Accounting)
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }
        }
    }
}