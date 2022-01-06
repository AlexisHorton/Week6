using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckofCardsLab.Models
{
   public class Deck
    {
        public string deck_id { get; set; }
        public int remaining { get; set; }
    }

    public class CardInfo
    {
        public string code { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string image { get; set; }
    }

    public class DrawCards
    {
        public string deck_id { get; set; }
        public int remaining { get; set; }

        public List<CardInfo> cards { get; set; }
    }
}
