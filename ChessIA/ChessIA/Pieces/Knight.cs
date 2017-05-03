using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Knight : Piece
    {
        public Knight(bool black) : base(black)
        {

        }

        public override bool canMove(Position endPos, Piece[] pieces)
        {
            foreach (Piece piece in pieces)
            {
                if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                {
                    return true;
                }
            }
            return false;
            throw new NotImplementedException();
        }
    }
}
