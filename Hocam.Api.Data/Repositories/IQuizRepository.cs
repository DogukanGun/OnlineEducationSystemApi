
using Hocam.Core.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Data.Repositories
{
    public interface IQuizRepository: IMongoRepository<QuizDocument>
    {
    }
}
