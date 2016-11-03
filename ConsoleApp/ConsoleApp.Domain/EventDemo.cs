using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  public class EventDemo
  {
    public delegate void TimerEvent();

    public event TimerEvent TicToc;

    public void BroadCast()
    {
      var timer = 0;

      while (timer < 5)
      {
        Thread.Sleep(2000);
        TicToc();
        timer += 1;
      }
    }

    public void Receiver(TimerEvent evt)
    {
      evt.TicToc += HandleMessage();
    }

    private void HandleMessage()
    {
      Console.WriteLine("message received");
    }
  }
}
