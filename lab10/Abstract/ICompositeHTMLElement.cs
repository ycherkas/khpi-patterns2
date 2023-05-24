namespace Lab10.Interfaces
{
    public interface ICompositeHTMLElement: IHTMLElement
    {
        List<IHTMLElement> Children { get; }

        void Append(IHTMLElement element);
    }
}
