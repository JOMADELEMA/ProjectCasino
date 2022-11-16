using System.Collections.Generic;

namespace DeckShuffler
{
    internal class Deck
    {
        public string Name { get; set; }
        public int id { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name, int id)
        {
            Name = name;
            this.id = id;
            Cards = new List<Card>();
        }
    }
}
