using System;
using System.Collections.Generic;

namespace DeckShuffler
{
    internal static class Utils
    {
        public static Icon[] createIcons()
        {
            Icon[] icons = new Icon[4];

            Icon spade = new Icon(1, "Spades", '♠');
            icons[0] = spade;
            Icon diamond = new Icon(1, "Diamonds", '♦');
            icons[1] = diamond;
            Icon heart = new Icon(1, "Hearts", '♥');
            icons[2] = heart;
            Icon clover = new Icon(1, "Clovers", '♣');
            icons[3] = clover;

            return icons;
        }

        public static Card[] CreateCardsForIcon(Icon icon)
        {
            Card[] cardsForIcon = new Card[13];
            for (int i = 0; i < 13; i++)
            {
                switch (i)
                {
                    case 0:
                        Card ace = new Card("Ace", i + 1, icon);
                        cardsForIcon[i] = ace;
                        break;
                    case 10:
                        Card jack = new Card("Jack", i + 1, icon);
                        cardsForIcon[i] = jack;
                        break;
                    case 11:
                        Card queen = new Card("Queen", i + 1, icon);
                        cardsForIcon[i] = queen;
                        break;
                    case 12:
                        Card king = new Card("King", i + 1, icon);
                        cardsForIcon[i] = king;
                        break;
                    default:
                        Card temp = new Card((i + 1).ToString(), i + 1, icon);
                        cardsForIcon[i] = temp;
                        break;
                }
            }
            return cardsForIcon;
        }

        public static void AddCardsToDeck(ref Deck deck, Card[] cards)
        {
            foreach (var card in cards)
            {
                deck.Cards.Add(card);
            }
        }

        public static List<int> GenerateRandomOrder()
        {
            List<int> order = new List<int>();
            Random rand = new Random();
            while (order.Count < 52)
            {
                int random = rand.Next(1, 53);
                if (!order.Contains(random))
                {
                    order.Add(random);
                }
            }

            return order;
        }

    }
}
