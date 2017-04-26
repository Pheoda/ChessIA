using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Knight : Piece
    {
		public Knight(Position position, bool black, String pathImage)
			: base(position, black, pathImage)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            throw new NotImplementedException();
        }
    }
}
