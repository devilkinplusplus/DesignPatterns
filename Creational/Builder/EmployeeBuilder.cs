using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class EmployeeBuilder
    {
        protected Employee Employee { get; set; }

        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAddress(string email);
        public abstract void SetSalary(float salary);

        public Employee Build() => Employee;
    }
}
