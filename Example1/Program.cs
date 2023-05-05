using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an arrray of integers, get the even numbers (LinQ using Query Sintax) ");
            exampleWithLinqUsingQuerySintax();
            Console.WriteLine("--------------------");
            Console.WriteLine("Given an arrray of integers, get the even numbers (LinQ using Method Sintax)");
            exampleWithLinqUsingMethodSintax();
            Console.WriteLine("--------------------");
            Console.WriteLine("Given an arrray of integers, get the even numbers(Example without LinQ)");
            exampleWithoutLinQ();
        }

        private static void exampleWithLinqUsingQuerySintax()
        {
            int[] numbers = Enumerable.Range(1, 6).ToArray();
            Console.WriteLine(string.Join(" ", numbers));

            IEnumerable<int> evenNumbers = from number in numbers
                                           where number % 2 == 0
                                           select number;
            Console.WriteLine("Even numbers:");
            foreach (int n in evenNumbers)
            {
                Console.WriteLine("{0}", n);

            }
        }
        private static void exampleWithLinqUsingMethodSintax()
        {// 
            int[] numbers = Enumerable.Range(1, 6).ToArray();
            Console.WriteLine(string.Join(" ", numbers));

            IEnumerable<int> evenNumbers = numbers.Where(number => number % 2 == 0);

            Console.WriteLine("Even numbers:");
            foreach (int n in evenNumbers)
            {
                Console.WriteLine("{0}", n);

            }
        }
        private static void exampleWithoutLinQ()
        {
            int[] numbers = Enumerable.Range(1, 6).ToArray();
            Console.WriteLine(string.Join(" ", numbers));

            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            Console.WriteLine("Even numbers:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine("{0}", n);

            }
        }
    }
}
