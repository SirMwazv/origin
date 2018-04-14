using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public interface IPlayer
    {
        string Name { get; }
        (int, int) GetMove();
    }
    class Player
    {
    }
}
