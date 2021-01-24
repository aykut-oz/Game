using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.Interfaces
{
    interface IIdentityVerificationService
    {
        bool TCQuery(string firstName, string surName, string tcNumber, int birthYear);
    }
}
