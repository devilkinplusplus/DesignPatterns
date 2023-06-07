using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InternalEmployeeBuilder : EmployeeBuilder
    {
        public InternalEmployeeBuilder() => Employee = new Employee();

        public override void SetEmailAddress(string email)
        {
            string internalEmailExtension = "@company.com";
            string[] emailAd = email.Split("@");
            Employee.Email = emailAd[0] + internalEmailExtension;
        }

        public override void SetFullName(string fullName)
        {
            string[] name = fullName.Split(" ");
            Employee.FirstName = name[0];
            Employee.LastName = name[1];
        }

        public override void SetSalary(float salary)
        {
            float salaryBonus = 500;
            float salaryExtra = 200;
            Employee.Salary = salary + salaryBonus + salaryExtra;
        }
    }
}
