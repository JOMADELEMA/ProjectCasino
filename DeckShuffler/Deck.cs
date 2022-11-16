using System.Collections.Generic;

namespace DeckShuffler
{
    internal class Deck
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name, int id)
        {
            Name = name;
            Id = id;
            Cards = new List<Card>();
        }
    }
}
