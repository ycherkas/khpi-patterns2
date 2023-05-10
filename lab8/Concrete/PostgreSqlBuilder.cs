using Lab8.Inferfaces;

namespace Lab8.Concrete
{
    public class PostgreSqlBuilder : IBuilder
    {
        private string _select;
        private string _where;
        private string _limit;

        public PostgreSqlBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _select = string.Empty;
            _where = string.Empty;
            _limit = string.Empty;
        }

        public void BuildSelect(string tableName)
        {
            _select = $"SELECT *{Environment.NewLine}FROM {tableName}";
        }

        public void BuildWhere(List<Constraint> constraints)
        {
            foreach(var constraint in constraints)
            {
                _select += $"{constraint.ColumnName} {constraint.Operator} {constraint.Value} \r\n";
            }
        }

        public void BuildLimit(int limit)
        {
            _limit = $"LIMIT {limit}";
        }

        public string GetSql()
        {
            var result = $"{_select}\r\n{_where}{_limit};";

            this.Reset();

            return result;
        }
    }
}
