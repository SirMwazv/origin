using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Checkers
{
    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        IEnumerable<int> CapturingMoves(IBoard board);
        Status Status { get; }
        Color Color { get; }
        int Position { get; }
        void Move(int destination);
    }
  public  class Piece
    {
        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }
        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }


       
    }
}
