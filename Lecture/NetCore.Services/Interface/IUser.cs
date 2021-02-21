using System;
using NetCore.Data.ViewModels;

namespace NetCore.Services.Interface
{
    public interface IUser
    {
        bool MatchTheUserInfo(LoginInfo login);
    }
}
