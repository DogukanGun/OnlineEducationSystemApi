using Hocam.Core.Data.Documents;
using Hocam.Core.Service.Models;
using System.Collections.Generic;

namespace Hocam.Core.Service.Modules.User
{
    public interface IUserService
    {
        public void RegisterUser(UserRegisterModel userRegisterModel); 
        List<UserModel> GetUsers(List<string> usernames);
        UserModel GetLoggedInUser();
        bool DeleteUser(); 
    }
}