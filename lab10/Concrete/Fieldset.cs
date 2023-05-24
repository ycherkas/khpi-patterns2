using Lab10.Interfaces;

namespace Lab10.Concrete
{
    public class Fieldset : ICompositeHTMLElement
    {
        private string _id;
        private List<IHTMLElement> _children;

        public Fieldset(string id, List<IHTMLElement> children)
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
<fieldset id=" + Id + ">" +
    childrenHtml +
"</fieldset>";
        }
    }
}
