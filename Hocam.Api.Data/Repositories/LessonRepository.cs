using Hocam.Core.Data.Documents;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Data.Repositories
{
    public class LessonRepository:BaseMongoRepository<LessonDocument>,ILessonRepository
    {
        public LessonRepository(IOptions<MongoDbOptions> options) : base(options)
        {

        }
    }
}
