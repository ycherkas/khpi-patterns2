using Lab6.Components;

namespace Lab6.Visitors
{
    public class SalaryReportVisitor : IVisitor
    {
        public string VisitCompany(Company company)
        {
            var report = company.Name + Environment.NewLine;

            for (var i = 0; i < company.Departaments.Count; i++)
            {
                report += $"{i + 1}. {VisitDepartament(company.Departaments[i])}";
            }

            return report;
        }

        public string VisitDepartament(Departament departament)
        {
            var report = departament.Name + Environment.NewLine;

            for(var i = 0; i < departament.Employees.Count; i++)
            {
                report += $"    {i + 1} {VisitEmployee(departament.Employees[i])}";
            }

            return report;
        }

        public string VisitEmployee(Employee employee)
        {
            return $"{employee.JobName}: {employee.SalaryInfo}" + Environment.NewLine;
        }
    }
}
