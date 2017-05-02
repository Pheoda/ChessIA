using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Bishop : Piece
    {
		public Bishop(Position position, bool black, String pathImage, TableLayoutPanel panel)
			: base(position, black, pathImage, panel)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            throw new NotImplementedException();
        }
    }
}
