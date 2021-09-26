using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocam.Core.Service.Models
{
    public class LogOnAuditModel
    {
        public string LoginDate { get; set; }
        public string IpAddress { get; set; }
        public string WebBrowser { get; set; }
        public int LoginStatus { get; set; }
        public string LoginStatusDescription { get; set; }
        public string Username { get; set; }
    }
}
