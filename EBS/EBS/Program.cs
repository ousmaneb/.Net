﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS
{
  class Program
  {
    static void Main(string[] args)
    {
      Deck deck = new Deck();

      deck.Shuffle();
      for(int i = 0; i<52; i++)
      {
        deck.Deal_card();
        if ((i + 1) % 4 == 0)
          Console.WriteLine();
      }
      Console.ReadKey();
    }
  }
}
