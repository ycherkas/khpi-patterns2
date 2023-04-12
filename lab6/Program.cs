using Lab6;
using Lab6.Components;
using Lab6.Visitors;

var engineeringEmployees = new List<Employee>()
{
    new Employee("Lead Developer", "5000$"),
    new Employee("Developer", "5000$"),
    new Employee("QA", "5000$"),
};

var marketingEmployees = new List<Employee>()
{
    new Employee("Markeing Specialist", "5000$"),
    new Employee("Lead Marketing Specialist", "5000$")
};

var hrEmployees = new List<Employee>()
{
    new Employee("Lead HR", "5000$"),
    new Employee("HR", "5000$")
};

var departments = new List<Departament>()
{
    new Departament("Engineering", engineeringEmployees),
    new Departament("Marketing", marketingEmployees),
    new Departament("HR", hrEmployees)
};

var companies = new List<IComponent>() {
    new Company("DreamCompany", departments)
};

var visitor = new SalaryReportVisitor();

Client.Process("Companies report", companies, visitor);
Client.Process("Departments report", departments.ToList<IComponent>(), visitor);
Client.Process("Employees report", engineeringEmployees.ToList<IComponent>(), visitor);

Console.ReadLine();