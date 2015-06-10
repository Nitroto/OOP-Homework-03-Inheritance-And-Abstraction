using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentAndWorker
{
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>() {
                new Student("Ivan","Petrov","156AWD987"),
                new Student("Dimitko","Dimitrov","ASR156QWE"),
                new Student("Petko","Petkov","PPP555PPP"),
                new Student("Minka","Milkova","69732156"),
                new Student("Petruna","Ivanova","369PLM5Z6A"),
                new Student("Goreto","Goshkov","5688APLSK"),
                new Student("Mariika","Marinova","3694ALCMFJ"),
                new Student("Stamat","Savtomat","3654ZLEPSK"),
                new Student("Parvi","Uchenik","123456789"),
                new Student("Zarko","Zzzz","9456ASD")
            };
            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan","Petrov",8,80M),
                new Worker("Petar","Ivanov",2,44.5M),
                new Worker("Georgi","Aleksandrov",6,100.3M),
                new Worker("Stamat","Savtomat",7,80M),
                new Worker("Harry","Potter",2.5,50M),
                new Worker("Minka","Milkova",3.4,40M),
                new Worker("Dimitar","Dimitrov",10,500M),
                new Worker("Todor","Petrov",12,500M),
                new Worker("Maria","Ivanova",1,50M),
                new Worker("Mariika","Marinova",0.5,10M)
            };
            var orderedStudents = students.OrderBy(student => student.FacultyNumber);
            var orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());
            List<Human> humans = new List<Human>(students.Count + workers.Count);
            humans.AddRange(students);
            humans.AddRange(workers);
            var orderedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
            PrintList(orderedStudents);
            PrintList(orderedWorkers);
            PrintList(orderedHumans);
        }

        private static void PrintList<T>(IOrderedEnumerable<T> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }
}
