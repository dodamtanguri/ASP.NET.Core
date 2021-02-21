using System;
using System.Collections.Generic;
using System.Linq;
using NetCore.Data.DataModels;
using NetCore.Data.ViewModels;
using NetCore.Services.Interface;

namespace NetCore.Services.Svcs
{
    public class UserService : IUser
    {
        #region private methods
        private IEnumerable<User> GetUserInfos()
        {
            return new List<User>()
            {
                new User()
                {
                    UserId = "soheeab",
                    UserName = "임도담",
                    UserEmail = "dodam@naver.com",
                    Password = "123456"
                }
            };
        }
        private bool checkTheUserInfo(string userId, string password)
        {
            return GetUserInfos().Where(u => u.UserId.Equals(userId) && u.Password.Equals(password)).Any();

        }


        #endregion

        bool IUser.MatchTheUserInfo(LoginInfo login)
        {
            return checkTheUserInfo(login.UserId, login.Password);
        }
    }
}

