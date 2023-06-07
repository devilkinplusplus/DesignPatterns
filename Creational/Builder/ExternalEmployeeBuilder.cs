using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ExternalEmployeeBuilder : EmployeeBuilder
    {
        public ExternalEmployeeBuilder() => Employee = new Employee();

        public override void SetEmailAddress(string email)
        {
            string externalEmailExtension = "@hotmail.com";
            string[] emailAd = email.Split("@");
            Employee.Email = emailAd[0] + externalEmailExtension;
        }

        public override void SetFullName(string fullname)
        {
            string[] name = fullname.Split(" ");
            Employee.FirstName = name[0];
            Employee.LastName = name[1];
        }

        public override void SetSalary(float salary)
        {
            float salaryBonus = 500;
            Employee.Salary = salary + salaryBonus;
        }
    }
}
