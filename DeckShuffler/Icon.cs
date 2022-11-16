﻿namespace DeckShuffler
{
    internal class Icon
    {
        public int Id;
        public string Name;
        public char Ico;
        public string Color;

        public Icon(int id, string name, char ico)
        {
            Id = id;
            Name = name;
            Ico = ico;
        }

        public override string ToString()
        {
            return $"Icon id: {Id} \nIcon Name: {Name}";
        }
    }
}
