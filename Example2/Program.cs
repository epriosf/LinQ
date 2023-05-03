using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Given an array of People, get women above 18");
            Console.WriteLine("---------------------------------");
            getWomenAbove18();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Given a List of People and Enterprise Objects, get people who works at Google");
            Console.WriteLine("---------------------------------");
            getPeopleWhoWorksAtGoogle();
        }
        private static void getWomenAbove18()
        {
            List<Person> employers = new List<Person>
                {
                new Person { Id=1, FirstName = "Alice", LastName="Evergreen", Age = 15, EnterpriseId=1, Gender="F" },
                new Person { Id=2,FirstName = "Bob", LastName="White", Age = 30, EnterpriseId=1, Gender="M"},
                new Person { Id=3,FirstName = "Charlie", LastName="Simmons", Age = 20, EnterpriseId=1, Gender="M" },
                new Person { Id=4,FirstName = "Diana", LastName="Smith", Age = 19, EnterpriseId=2, Gender="F" },
                new Person { Id=5,FirstName = "Eve", LastName="Evergreen", Age = 22, EnterpriseId=2, Gender="F" }
                };

            List<Enterprise> enterprises = new List<Enterprise>
                {
                new Enterprise { Id=1, Name = "Google"},
                new Enterprise { Id=2, Name = "Microsoft"}
                };
            /* Method Sintax
            IEnumerable<Person> femaleAbove18 = employers.Where(employer => employer.Age > 18 && employer.Gender == "F");*/

            // Query Sintax
            IEnumerable<Person> femaleAbove18 = from employer in employers
                                                where employer.Age > 18 && employer.Gender == "F"
                                                select employer;

            foreach (var n in femaleAbove18)
            {
                Console.WriteLine(n.ToString());
            }
        }

        private static void getPeopleWhoWorksAtGoogle()
        {
            List<Person> employers = new List<Person>
                {
                new Person { Id=1, FirstName = "Alice", LastName="Evergreen", Age = 15, EnterpriseId=1, Gender="F" },
                new Person { Id=2,FirstName = "Bob", LastName="White", Age = 30, EnterpriseId=1, Gender="M"},
                new Person { Id=3,FirstName = "Charlie", LastName="Simmons", Age = 20, EnterpriseId=1, Gender="M" },
                new Person { Id=4,FirstName = "Diana", LastName="Smith", Age = 19, EnterpriseId=2, Gender="F" },
                new Person { Id=5,FirstName = "Eve", LastName="Evergreen", Age = 22, EnterpriseId=2, Gender="F" }
                };

            List<Enterprise> enterprises = new List<Enterprise>
                {
                new Enterprise { Id=1, Name = "Google"},
                new Enterprise { Id=2, Name = "Microsoft"}
                };
            /* Method Sintax
            IEnumerable<Person> peopleInGoogle = employers
            .Join(enterprises, employer => employer.EnterpriseId, enterprise => enterprise.Id, (employer, enterprise) => new { Employer = employer, Enterprise = enterprise })
            .Where(joinResult => joinResult.Enterprise.Name == "Google")
            .Select(joinResult => joinResult.Employer);
            */

            // Query Sintax
            IEnumerable<Person> peopleInGoogle = from employer in employers
                                                 join enterprise in enterprises on employer.EnterpriseId equals enterprise.Id
                                                 where enterprise.Name == "Google"
                                                 select employer;

            foreach (var person in peopleInGoogle)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
