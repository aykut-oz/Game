using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.Interfaces.Service
{
    interface IAuthorizationService
    {
        void AddUserAuthorization(long userId,string authorizationName);
    }
}
