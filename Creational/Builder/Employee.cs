using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return $"Full name : {FirstName} {LastName}\n" +
                   $"Email : {Email}\n" +
                   $"Net Salary : {Salary}";
        }
    }
}
