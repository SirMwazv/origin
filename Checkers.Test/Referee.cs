using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers.Test
{
    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();
    }
    public class IllegalMoveException : ApplicationException { }

    class Referee
    {
    }
}
