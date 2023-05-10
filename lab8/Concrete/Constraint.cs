namespace Lab8.Concrete
{
    public class Constraint
    {
        public string ColumnName { get; set; }

        public string Operator { get; set; }

        public dynamic Value { get; set; }

        public bool IsNumerical { get; set; }
    }
}
