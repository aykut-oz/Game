using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Game
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public string PosterUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsAutomaticSale { get; set; }
        public double SalePrice { get; set; }
        public long CurrencyId { get; set; }
        public string GameType { get; set; }
    }
}
