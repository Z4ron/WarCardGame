using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WarCardGame
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck(bool Full)
        {
            if (Full)
            {
                // Clubs
                for (int i = 2; i <= 14; i++)
                {
                    String ImageLocation = Directory.GetCurrentDirectory() + "\\Assets\\PNG\\Cards\\" + i.ToString() + "C.png";
                    cards.Add(new Card(Suite.Clubs, i, ImageLocation));
                }

                // Spades
                for (int i = 2; i <= 14; i++)
                {
                    String ImageLocation = Directory.GetCurrentDirectory() + "\\Assets\\PNG\\Cards\\" + i.ToString() + "S.png";
                    cards.Add(new Card(Suite.Spades, i, ImageLocation));
                }

                // Diamonds
                for (int i = 2; i <= 14; i++)
                {
                    String ImageLocation = Directory.GetCurrentDirectory() + "\\Assets\\PNG\\Cards\\" + i.ToString() + "D.png";
                    cards.Add(new Card(Suite.Diamonds, i, ImageLocation));
                }

                // Hearts
                for (int i = 2; i <= 14; i++)
                {
                    String ImageLocation = Directory.GetCurrentDirectory() + "\\Assets\\PNG\\Cards\\" + i.ToString() + "H.png";
                    cards.Add(new Card(Suite.Hearts, i, ImageLocation));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 1; i < cards.Count; i++)
            {
                int SwapIndex = rand.Next(0, cards.Count - 1);
                Card CardToSwap = cards[SwapIndex];
                cards[SwapIndex] = cards[i];
                cards[i] = CardToSwap;
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void AddCardToBottom(Card card)
        {
            cards.Insert(0, card);
        }

        public Card DrawCard()
        {
            Card drawn = cards[cards.Count-1];
            cards.Remove(drawn);
            return drawn;
        }

        public int Size()
        {
            return cards.Count();
        }
    }

}
