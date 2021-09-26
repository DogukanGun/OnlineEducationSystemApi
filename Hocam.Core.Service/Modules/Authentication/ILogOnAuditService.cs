using Hocam.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Modules.Authentication
{
    public interface ILogOnAuditService
    {
        public void SaveFailedLogin(string status, string name);
        public void SaveSuccessfulLogin(string name);
        public List<LogOnAuditModel> GetLogins();
    }
}
