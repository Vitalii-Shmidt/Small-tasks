namespace CardDeck {
    public class Card {
        public Name Name { get; set; }
        public CardType Type { get; set; }
        public override string ToString() {
            return $"{Name}\t\t{Type}";
        }
        public Card() { }
        public Card(Name name, CardType type) {
            Name = name;
            Type = type;
        }
        public Card(Card other) {
            Type = other.Type;
            Name = other.Name;
        }
    }
}
