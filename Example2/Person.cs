using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int EnterpriseId { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName:{LastName}\nAge: {Age}\nGender:{Gender}\nEnterpriseId:{EnterpriseId}\n";
        }
    }
}
