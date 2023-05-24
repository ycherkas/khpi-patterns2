using Lab10.Interfaces;

namespace Lab10.Concrete
{
    public class Select : IHTMLElement
    {
        private string _id;

        private string[] _options;

        public Select(string id, string[] options)
        {
            _id = id;
            _options = options;
        }

        public string Id => string.IsNullOrEmpty(_id) ? _id = Guid.NewGuid().ToString() : _id;

        public string Render()
        {
            var optionsHtml = string.Empty;

            foreach (var option in _options)
            {
                optionsHtml += $"<option>${option}</option>\r\n";
            }

            return @"
<select id=" + Id + ">" +
    optionsHtml + 
"</select>";
        }
    }
}
