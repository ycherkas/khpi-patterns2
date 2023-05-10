
using Lab8.Concrete;

var mySqlBuilder = new MySqlBuilder();
var postgreSqlBuilder = new PostgreSqlBuilder();

var constraints = new List<Constraint>()
{
    new Constraint { ColumnName="FirstName", Operator="=", Value="Ivan" },
    new Constraint { ColumnName="Age", Operator=">", Value=12, IsNumerical = true }
};

var director = new Director();

director.Builder = mySqlBuilder;

var query = director.BuildQuery("students");
Console.WriteLine($"MySql: select:\r\n{query}");

query = director.BuildQuery(tableName: "students", limit: 10);
Console.WriteLine($"MySql: select + limit:\r\n{query}");

query = director.BuildQuery(tableName: "students", constraints: constraints, limit: 10);
Console.WriteLine($"MySql: select + where + limit:\r\n{query}");


director.Builder = postgreSqlBuilder;
query = director.BuildQuery(tableName: "students", constraints: constraints, limit: 10);
Console.WriteLine($"PostgreSql: select + where + limit:\r\n{query}");