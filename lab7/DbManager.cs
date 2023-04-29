using Lab7.Interfaces;
using Laboratory2.Concrete;

namespace Lab7
{
    public class DbManager
    {
        public static IDbRepository GetRepository(DbType type)
        {
            switch(type)
            {
                case DbType.PostgreSql:
                    return PostgreSqlRepository.GetInstance();

                case DbType.MongoDb: 
                    return MongoDbRepository.GetInstance();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
