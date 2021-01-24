using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    interface ICampaignService
    {
        void Create();
        void Update();
        void Delete(int campaignId);
        void List();
    }
}
