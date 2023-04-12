using Lab6.Visitors;

namespace Lab6.Components
{
    public class Company : IComponent
    {
        public string Name { get; private set; }

        public List<Departament> Departaments { get; private set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitCompany(this);
        }

        public Company(string name, List<Departament> departaments)
        {
            Name = name;
            Departaments = departaments;
        }
    }
}
