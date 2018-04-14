using System;
using System.Collections.Generic;
using System.Text;

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
    class Piece
    {
       
    }
}
