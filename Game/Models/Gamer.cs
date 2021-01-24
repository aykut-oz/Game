using GalaxyReederGame.Interfaces.Class;
using GalaxyReederGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame
{
    public class Gamer: UserBase
    {
        public string IdentityNumber { get; set; }
        public int BirthYear { get; set; }
        public int  JoinCampaignCount{ get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
