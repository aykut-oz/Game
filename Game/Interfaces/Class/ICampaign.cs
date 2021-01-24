using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces.Class
{
     interface ICampaign
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public double CampaignAmount { get; set; }
        public int CampaignStock { get; set; }
        public int PercentageDiscount { get; set; }
    }
}
