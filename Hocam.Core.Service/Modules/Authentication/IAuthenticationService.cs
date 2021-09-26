﻿namespace Hocam.Core.Service.Modules.Authentication
{
    public interface IAuthenticationService
    {
        public string Authenticate(string userId, string password);
        public void ResetPassword(string username);
        public bool ChangePassword(string password, string newPassword);
    }
}
