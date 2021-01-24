using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    interface IIdentityVerificationService
    {
        bool TCQuery(string firstName, string surName, string tcNumber, int birthYear);
    }
}
