using System;

namespace DeckShuffler
{
    public class Card
    {
        private readonly string Id;
        private readonly int Value;
        public Icon icon;

        public Card(string id, int value, Icon icon)
        {
            Id = id;
            Value = value;
            this.icon = icon;
        }

        public override string ToString()=> $"Card Id: {Id}\nCard Value: {Value}\nCard Icon: {icon.Name}";
        public void CardInfo() => Console.WriteLine($"{Id} of {icon.Ico}");
        public int GetCardValue() => Value;
        public void PrintValue() =>  Console.WriteLine(Value);
    }
}
