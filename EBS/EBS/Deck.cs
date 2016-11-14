using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS
{
  class Deck
  {

    public void Deck_card(string [] s, int [] n)
    {

  

    
      Random rnd = new Random();
      int number_rnd= rnd.NextInt32(n); // creates a number between 1 and 12
      string suit_rd = rnd.Next(s);   // creates a number between 1 and 6
    
    }


  }
}
