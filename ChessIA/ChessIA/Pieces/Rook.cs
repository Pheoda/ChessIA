using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Rook : Piece
    {
		public Rook(Position position, bool black, String pathImage)
			: base(position, black, pathImage)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
			// Une tour peut bouger suivant un unique axe
			return this.position.getX() == endPos.getX() || this.position.getY() == endPos.getY();
        }
    }
}
