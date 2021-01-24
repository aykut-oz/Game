using Game.AppServices;
using Game.Interfaces.Class;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    public interface IUserService
    {
        long CreateAndReturnUserId(UserBase user);
        void Update(UserBase user);
        void Delete(long userId);
        void List(List<UserBase> users);
        void GetUser(long userId);
     
    }
}
