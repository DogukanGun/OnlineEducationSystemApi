using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hocam.Core.Service
{
    public interface IContextResolver
    {
        public string GetUsername();
        public string GetIPAddress();
        public string GetWebBrowser();
        public string GetDate();
    }
}
