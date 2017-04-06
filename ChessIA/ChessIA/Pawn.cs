using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Pawn : Piece
    {
        private bool isFirstMove;

        public Pawn(bool black) : base(black)
        {
            isFirstMove = true;
        }
    }
}
