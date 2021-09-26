using Hocam.Core.Service.Configurations;
using System.Collections.Generic;

namespace Hocam.Core.Service.Modules.Authentication
{
    public interface ISecurityService
    {
        public string GeneratePassword();
        public byte[] GenerateRandomSalt();
        public string GenerateHashedPassword(byte[] salt, string password);
        public string GenerateToken(JwtOptions jwtOptions, string username);
     }
}
