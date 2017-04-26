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

		public Pawn(Position position, bool black, String pathImage)
			: base(position, black, pathImage)
        {
            isFirstMove = true;
        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            throw new NotImplementedException();
        }
    }
}
