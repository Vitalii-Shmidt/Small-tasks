using System;
using System.Linq;

namespace CardDeck {
    class Program {
        static void Main(string[] args) {
            var deck = new Card[] {
                 new Card(Name.six, CardType.clubs),
                 new Card(Name.nine, CardType.clubs),
                 new Card(Name.nine, CardType.diamonds),
                 new Card(Name.ten, CardType.hearts),
                 new Card(Name.six, CardType.hearts),
                 new Card(Name.seven, CardType.clubs),
                 new Card(Name.eight, CardType.hearts),
                 new Card(Name.eight, CardType.spades),
                 new Card(Name.six, CardType.spades),
                 new Card(Name.six, CardType.diamonds),
                 new Card(Name.eight, CardType.clubs),
                 new Card(Name.eight, CardType.diamonds),
                 new Card(Name.king, CardType.spades),
                 new Card(Name.king, CardType.clubs),
                 new Card(Name.nine, CardType.hearts),
                 new Card(Name.nine, CardType.spades),
                 new Card(Name.ace, CardType.spades),
                 new Card(Name.ace, CardType.clubs),
                 new Card(Name.ace, CardType.diamonds),
                 new Card(Name.joker, CardType.black),
                 new Card(Name.ten, CardType.spades),
                 new Card(Name.ten, CardType.clubs),
                 new Card(Name.ten, CardType.diamonds),
                 new Card(Name.jack, CardType.hearts),
                 new Card(Name.jack, CardType.spades),
                 new Card(Name.jack, CardType.clubs),
                 new Card(Name.jack, CardType.diamonds),
                 new Card(Name.queen, CardType.hearts),
                 new Card(Name.queen, CardType.spades),
                 new Card(Name.queen, CardType.clubs),
                 new Card(Name.seven, CardType.diamonds),
                 new Card(Name.seven, CardType.hearts),
                 new Card(Name.seven, CardType.spades),
                 new Card(Name.queen, CardType.diamonds),
                 new Card(Name.king, CardType.hearts),
                 new Card(Name.king, CardType.diamonds),
                 new Card(Name.ace, CardType.hearts),
                 new Card(Name.joker, CardType.white)
                 };
            int firstLetterCounter = 0;
            int tabulationCounter = 0;
            foreach (var card in deck.OrderByDescending(card => card.Name).ThenBy(card => card.Type)) {
                Console.WriteLine($"{++firstLetterCounter}.{(firstLetterCounter == 1 ? "I" : "i")}tem:{(tabulationCounter++ < 9 ? "\t\t" : "\t")}{card}");
            }

            Console.ReadKey();
        }
    }
}
