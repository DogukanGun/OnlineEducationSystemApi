
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Data.Repositories
{
    public class QuizRepository : BaseMongoRepository<QuizDocument>, IQuizRepository
    {
        public QuizRepository(IOptions<MongoDbOptions> options):base(options)
        {

        }
    }
}
