using GalaxyReederGame.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.AppServices
{
    class AuthorizationService : IAuthorizationService
    {
        public void AddUserAuthorization(long userId, string authorizationName)
        {
            if (userId>0 && authorizationName!="")
            {
                Console.WriteLine("Number "+userId+" is authorized with "+ authorizationName);
            }
            else
            {
                Console.WriteLine("User is not authorized");
            }
        }
    }
}
