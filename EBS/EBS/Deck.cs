
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS
{
  /* -----------------------------------------------------
        Deck: a deck of cards
    ----------------------------------------------------- */

  class Deck
  {

    public Card[] deck;
    Random random_number;
    public int current = 0;
    public const int Number_OF_CARDS = 52;
    

    public Deck()
    {
      string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "J", "Q" };
      string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

     deck = new Card[Number_OF_CARDS];
      random_number = new Random();



      for (int i = 0; i < deck.Length; i++)
      {
        deck[i] = new Card(ranks[i % 13], suits[i / 13]);
      }
    }


    public void Shuffle()
    {
      current = 0;
      for (int i = 0; i < deck.Length; i++)
      {
        int j = random_number.Next(Number_OF_CARDS);
        Card temp = deck[i];
        deck[i] = deck[j];
        deck[j] = temp;
      }
    }


    public void Deal_card()
    {
      if (current < deck.Length)
        deck[current++].Display_card();
    }
}

}
