using Hocam.Core.Data.Documents;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hocam.Core.Data.Repositories
{
    public class UserRepository : BaseMongoRepository<UserDocument>, IUserRepository
    {
        public UserRepository(IOptions<MongoDbOptions> options) : base(options)
        {

        }
    }
}
