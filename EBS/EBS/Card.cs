using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS
{
  class Card
  {
    private string Rank;
    private string Suit;
    

    public Card(string rank, string suit)
    {
      Rank = rank;
      Suit = suit;
    }

    public void Display_card()
    {
      Console.Write("{0, -19}", Rank+" of "+Suit);
    }
  }
}
