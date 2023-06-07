using Builder;

EmployeeBuilder employee = new InternalEmployeeBuilder();

employee.SetFullName("Ilkin Rufullayev");
employee.SetEmailAddress("rufullayevilkin66@gmail.com");
employee.SetSalary(1000);
string empl = employee.Build().ToString();

Console.WriteLine(empl);
Console.WriteLine("------------");

EmployeeBuilder employee1 = new ExternalEmployeeBuilder();

employee1.SetFullName("Murad Rufullayev");
employee1.SetEmailAddress("muradrufullayev@gmail.com");
employee1.SetSalary(750);

var empl1 = employee1.Build().ToString();
Console.WriteLine(empl1);