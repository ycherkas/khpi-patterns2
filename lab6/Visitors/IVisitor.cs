using Lab6.Components;

namespace Lab6.Visitors
{
    public interface IVisitor
    {
        string VisitEmployee(Employee employee);

        string VisitDepartament(Departament departament);

        string VisitCompany(Company company);
    }
}
