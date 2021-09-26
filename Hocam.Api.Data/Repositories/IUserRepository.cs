using Hocam.Core.Data.Abstractions;
using Hocam.Core.Data.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Data.Repositories
{
    public interface IUserRepository : IMongoRepository<UserDocument>
    {

    }
}
