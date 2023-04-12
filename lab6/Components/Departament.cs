using Lab6.Visitors;

namespace Lab6.Components
{
    public class Departament : IComponent
    {
        public string Name { get; private set; }

        public List<Employee> Employees { get; private set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitDepartament(this);
        }

        public Departament(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
    }
}
