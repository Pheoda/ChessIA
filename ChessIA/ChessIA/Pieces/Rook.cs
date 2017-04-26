using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Rook : Piece
    {
        public Rook(bool black) : base(black)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
			// Une tour peut bouger suivant un unique axe
			return this.position.getX() == endPos.getX() || this.position.getY() == endPos.getY();
        }
    }
}
