using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("miau miau");
        }
         public override string ToString()
        {
            return $"Id:{Id} Breed:{Breed} Age:{Age} Name:{Name}";
        }
    }
}
