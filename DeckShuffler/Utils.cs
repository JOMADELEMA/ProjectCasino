using System;
using System.Collections.Generic;

namespace DeckShuffler
{
    public static class Utils
    {
        public static Icon[] CreateIcons()
        {
            Icon[] icons = new Icon[4];

            Icon heart = new Icon(1, "Hearts", '♥');
            icons[0] = heart;
            Icon clubs = new Icon(1, "Clovers", '♣');
            icons[1] = clubs;
            Icon diamond = new Icon(1, "Diamonds", '♦');
            icons[2] = diamond;
            Icon spade = new Icon(1, "Spades", '♠');
            icons[3] = spade;

            return icons;
        }

        public static Card[] CreateCards(Icon icon)
        {
            Card[] cards = new Card[13];
            for (int i = 0; i < 13; i++)
            {
                switch (i)
                {
                    case 0:
                        Card ace = new Card("Ace", i + 1, icon);
                        cards[i] = ace;
                        break;
                    case 10:
                        Card jack = new Card("Jack", i + 1, icon);
                        cards[i] = jack;
                        break;
                    case 11:
                        Card queen = new Card("Queen", i + 1, icon);
                        cards[i] = queen;
                        break;
                    case 12:
                        Card king = new Card("King", i + 1, icon);
                        cards[i] = king;
                        break;
                    default:
                        Card temp = new Card((i + 1).ToString(), i + 1, icon);
                        cards[i] = temp;
                        break;
                }
            }
            return cards;
        }

        public static void AddCardsToDeck(ref Deck deck, Card[] cards)
        {
            foreach (var card in cards)
                deck.Cards.Add(card);
        }

        public static Deck CreateDeck(string deckName, int id)
        {
            Icon[] icons = CreateIcons();
            Deck deck = new Deck(deckName, id);

            Card[] hearts = CreateCards(icons[0]);
            Card[] clubs = CreateCards(icons[1]);
            Card[] diamonds = CreateCards(icons[2]);
            Card[] spades = CreateCards(icons[3]);


            AddCardsToDeck(ref deck, hearts);
            AddCardsToDeck(ref deck, clubs);
            AddCardsToDeck(ref deck, diamonds);
            AddCardsToDeck(ref deck, spades);

            return deck;
        }

        public static List<int> GenerateRandomOrder(int maxNumber)
        {
            List<int> order = new List<int>();

            Random rand = new Random();

            while (order.Count < maxNumber)
            {
                int random = rand.Next(1, maxNumber+1);
                if (!order.Contains(random))
                    order.Add(random);
            }

            return order;
        }

        

        public static Stack<Card> CreateShuffledDeck(Deck orderedDeck)
        {
            Stack<Card> shuffledDeck = new Stack<Card>();

            List<int> numbers = GenerateRandomOrder(52);
            foreach(var number in numbers)
                shuffledDeck.Push(orderedDeck.Cards[number - 1]);

            return shuffledDeck;
        }

        public static void ShowShuffledDeck(Stack<Card> shuffledDeck)
        {
            foreach(var card in shuffledDeck)
                card.CardInfo();
        }
    }
}
