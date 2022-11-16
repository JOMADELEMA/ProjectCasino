using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DeckShuffler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Icon[] icons = Utils.createIcons();

            Card[] spades = Utils.CreateCardsForIcon(icons[0]);
            Card[] diamonds = Utils.CreateCardsForIcon(icons[1]);
            Card[] hearts = Utils.CreateCardsForIcon(icons[2]);
            Card[] clovers = Utils.CreateCardsForIcon(icons[3]);

            Deck deck = new Deck("Blackjack", 1);

            Utils.AddCardsToDeck(ref deck, spades);
            Utils.AddCardsToDeck(ref deck, diamonds);
            Utils.AddCardsToDeck(ref deck, hearts);
            Utils.AddCardsToDeck(ref deck, clovers);

            Stack<Card> shuffledDeck = new Stack<Card>();

            List<int> numbers = Utils.GenerateRandomOrder();

            foreach (var number in numbers)
            {
                shuffledDeck.Push(deck.Cards[number-1]);
            }

            foreach(var card in shuffledDeck)
            {
                card.CardInfo();
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }

}
