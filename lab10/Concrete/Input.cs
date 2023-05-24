using Lab10.Interfaces;

namespace Lab10.Concrete
{
    public class Input : IHTMLElement
    {
        private string _id;

        public Input(string id)
        {
            _id = id;
        }

        public string Id => string.IsNullOrEmpty(_id) ? _id = Guid.NewGuid().ToString() : _id;

        public string Render()
        {
            return $"<input id={Id}></input>";
        }
    }
}
