namespace Lab2.Abstract
{
    public abstract class Component
    {
        protected IMediator _mediator;

        public bool IsActive { get; set; }

        public Component(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
