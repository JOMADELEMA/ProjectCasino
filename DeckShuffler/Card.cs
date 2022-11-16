using System;

namespace DeckShuffler
{
    internal class Card
    {
        private string Id;
        private int Value;
        public Icon icon;

        public Card(string id, int value, Icon icon)
        {
            Id = id;
            Value = value;
            this.icon = icon;
        }

        public override string ToString()
        {
            return $"Card Id: {Id}\nCard Value: {Value}\nCard Icon: {icon.Name}";
        }

        public void CardInfo()
        {
            Console.WriteLine($"Card: {Id} of {icon.Ico}");
        }

        public int GetCardValue() => Value;

        public void PrintValue() =>  Console.WriteLine(Value);
    }
}
