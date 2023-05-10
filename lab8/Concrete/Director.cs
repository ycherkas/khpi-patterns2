using Lab8.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Concrete
{
    public class Director
    {
        public IBuilder Builder { get; set; }

        public string BuildQuery(string tableName)
        {
            Builder.BuildSelect(tableName);

            return Builder.GetSql();
        }

        public string BuildQuery(string tableName, int limit)
        {
            Builder.BuildSelect(tableName);

            Builder.BuildLimit(limit);

            return Builder.GetSql();
        }

        public string BuildQuery(string tableName, List<Constraint> constraints)
        {
            Builder.BuildSelect(tableName);

            Builder.BuildWhere(constraints);

            return Builder.GetSql();
        }

        public string BuildQuery(string tableName, List<Constraint> constraints, int limit)
        {
            Builder.BuildSelect(tableName);

            Builder.BuildWhere(constraints);

            Builder.BuildLimit(limit);

            return Builder.GetSql();
        }
    }
}
