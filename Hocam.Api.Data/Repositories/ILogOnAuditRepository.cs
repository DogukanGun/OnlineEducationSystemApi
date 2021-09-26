using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hocam.Core.Data.Abstractions;
using Hocam.Core.Data.Documents;

namespace Hocam.Core.Data.Repositories
{
    public interface ILogOnAuditRepository : IMongoRepository<LogOnAuditDocument>
    {
     }
}
