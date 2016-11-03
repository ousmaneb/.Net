using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  public interface IForm
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    double Perimeter();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    double Surface();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    double Volume();
  }

  public interface IMove
  {
    void Move();
  }

  public class Queen : IMove
  {
    public void Move()
    {
      // Move up vertical, horizantal or diganal until blocked or edge of board
    }
  }

  public class King : IMove
  {
    public void Move()
    {
      // Move one space in any direction
    }
  }

  public class Board
  {
    public List<IMove> Pieces { get; set; }
    public Board()
    {
      Pieces = new List<IMove>();
      Pieces.Add(new Queen());
      Pieces.Add(new King());
      foreach (var Piece in Pieces)
      {
        Piece.Move();
      }
     // Pieces.Select();
    }
  }

}