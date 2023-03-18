namespace Lab2.Abstract
{
    public interface IMediator
    {
        void Notify(Component sender, EventArg eventArg);
    }
}
