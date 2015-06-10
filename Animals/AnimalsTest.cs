using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class AnimalsTest
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>() {
                new Dog("Sharo", 2, "male"),
                new Dog("Balkan",5,"Male"),
                new Dog("Herra", 10, "female"),
                new Frog("Kermit", 12, "male"),
                new Kitten("Maca", 1),
                new Tomcat("Puhcho",2),
                new Kitten("Pisi",4),
                new Tomcat("Topcho",3)
            };

            var averageCatAge = animals.Where(animal => animal is Cat).Average(cat => cat.Age);
            var averageKittenAge = animals.Where(animal => animal is Kitten).Average(kitten => kitten.Age);
            var averageTomcatAge = animals.Where(animal => animal is Tomcat).Average(tomcat => tomcat.Age);
            var averageDogAge= animals.Where(animal => animal is Dog).Average(dog => dog.Age);
            var averageFrogAge = animals.Where(animal => animal is Frog).Average(frog => frog.Age);
            Console.WriteLine("Cat: {0:F2}{5}Kitten: {1:F2}{5}Tomcat: {2:F2}{5}Dog: {3:F2}{5}Frog: {4:F2}{5}", averageCatAge,averageKittenAge,averageTomcatAge,averageDogAge,averageFrogAge,Environment.NewLine);
        }
    }
}
