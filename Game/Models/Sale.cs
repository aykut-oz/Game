using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame
{
    class Sale
    {
        public long Id { get; set; }
        
        public long UserId { get; set; }
        public double PaymentAmount { get; set; }
        public long GameId { get; set; }
        public long? CampaginId { get; set; }
    }
}
