using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("woof woof");
        }
        public override string ToString()
        {
            return $"Id:{Id} Breed:{Breed} Age:{Age} Name:{Name}";
        }
    }
}
