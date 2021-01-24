using GalaxyReederGame.AppServices;
using GalaxyReederGame.Interfaces.Class;
using GalaxyReederGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.Interfaces
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
