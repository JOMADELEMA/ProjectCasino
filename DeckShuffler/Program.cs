using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DeckShuffler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = Utils.CreateDeck("Blackjack", 1);
            Stack<Card> shuffledDeck = Utils.CreateShuffledDeck(deck);
            Utils.ShowShuffledDeck(shuffledDeck);

            Console.ReadKey();
        }
    }

}
