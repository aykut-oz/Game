using Game.Interfaces.Class;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Gamer: UserBase
    {
        public string IdentityNumber { get; set; }
        public int BirthYear { get; set; }
        public int  JoinCampaignCount{ get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
