namespace Lab3
{
    class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();

        private Cabinet _cabinet;

        public Caretaker(Cabinet cabinet)
        {
            this._cabinet = cabinet;
        }

        public void CreateBackup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this._mementos.Add(this._cabinet.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            this._cabinet.Restore(memento);
        }
    }
}
