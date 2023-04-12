using Lab6.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Components

{
    public interface IComponent
    {
        string Accept(IVisitor visitor);
    }
}
