using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Pawn : Piece
    {
        private bool isFirstMove;

		public Pawn(Position position, bool black, Image image, TableLayoutPanel panel)
			: base(position, black, image, panel)
        {
            isFirstMove = true;
        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            throw new NotImplementedException();
        }
    }
}
