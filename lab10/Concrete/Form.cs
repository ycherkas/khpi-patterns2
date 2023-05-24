using Lab10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Concrete
{
    public class Form : ICompositeHTMLElement
    {
        private string _id;
        private List<IHTMLElement> _children;

        public Form(string id, List<IHTMLElement> children)
        {
            _id = id;
            _children = children;
        }

        public string Id => string.IsNullOrEmpty(_id) ? _id = Guid.NewGuid().ToString() : _id;

        public List<IHTMLElement> Children => _children;

        public void Append(IHTMLElement element)
        {
            _children.Add(element);
        }

        public string Render()
        {
            var childrenHtml = string.Empty;

            foreach (var child in _children)
            {
                childrenHtml += child.Render() + Environment.NewLine;
            }

            return @"
<form id=" + Id + ">" +
    childrenHtml +
"</form>";
        }
    }
}
