using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
                                    {
                                        new Dog(){Id =1, Name="Ricky", Breed="snauzer", Age=5},
                                        new Dog(){Id =1, Name="Rocky", Breed="Beagle", Age=10},
                                        new Cat(){Id = 2, Name = "Charlie", Breed = "Persian Cat", Age = 10 },
                                         new Cat(){Id = 2, Name = "Rosy", Breed = "Siames", Age = 8 }
                                    };
            getAnimalsOfTypeDog(animals);
            getFirstDogFromAnimals(animals);
            getFirstDogFromAnimalsUsingFirstOrDefault();
        }

        private static void getFirstDogFromAnimals(List<Animal> animals)
        {
            Console.WriteLine("\nGiven a list of animals, return the first dog found");
            Console.WriteLine("_____________________________________________");

            try
            {
                var firstDog = animals.OfType<Dog>().First(dog => dog.Age < 12);
                Console.WriteLine(firstDog.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("No dogs Found\n{0}", e);
            }
        }
        private static void getFirstDogFromAnimalsUsingFirstOrDefault()
        {
            List<Animal> animals = new List<Animal>()
                                    {
                                        new Cat(){Id = 2, Name = "Charlie", Breed = "Persian Cat", Age = 10 },
                                        new Cat(){Id = 2, Name = "Rosy", Breed = "Siames", Age = 8 }
                                    };
            Console.WriteLine("\nGiven a list of animals, return the first dog found");
            Console.WriteLine("_____________________________________________");

            var firstDog = animals.OfType<Dog>().FirstOrDefault(dog => dog.Age < 12);

            Console.WriteLine(firstDog?.ToString() ?? "No Dog found");

        }

        private static void getAnimalsOfTypeDog(List<Animal> animals)
        {
            Console.WriteLine("Given a list of animals, return who are dogs sorting by age in ascending way");
            Console.WriteLine("_____________________________________________");
            IEnumerable<Dog> dogsAscending = animals.OfType<Dog>().OrderBy(dog => dog.Age);
            dogsAscending.ToList().ForEach(dog => Console.WriteLine(dog.ToString()));

            Console.WriteLine("Given a list of animals, return who are dogs sorting by age in descending way");
            Console.WriteLine("_____________________________________________");
            IEnumerable<Dog> dogsDescending = animals.OfType<Dog>().OrderByDescending(dog => dog.Age);
            dogsDescending.ToList().ForEach(dog => Console.WriteLine(dog.ToString()));
        }
    }
}
