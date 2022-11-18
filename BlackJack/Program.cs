using DeckShuffler;
using System;
using System.Collections.Generic;

namespace BlackJack

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = Utils.CreateDeck("BlackJack", 1);
            Stack<Card> shuffledDeck = Utils.CreateShuffledDeck(deck);
            foreach(var card in shuffledDeck)
            {
                card.CardInfo();
            }
            Utils.ShowShuffledDeck(shuffledDeck);
            Console.ReadKey();

        }
    }
}
