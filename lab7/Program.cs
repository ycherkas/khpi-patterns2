using Lab7;


var postgreSqlRepository = DbManager.GetRepository(DbType.PostgreSql);
var mongoDbRepository = DbManager.GetRepository(DbType.MongoDb);

var model = postgreSqlRepository.Read(id: 1);
mongoDbRepository.Create(model);
