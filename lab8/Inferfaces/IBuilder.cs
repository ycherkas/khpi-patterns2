using Lab8.Concrete;

namespace Lab8.Inferfaces
{
    public interface IBuilder
    {
        void Reset();

        void BuildSelect(string tableName);

        void BuildWhere(List<Constraint> constraints);

        void BuildLimit(int limit);

        string GetSql();
    }
}
