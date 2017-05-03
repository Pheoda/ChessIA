using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Rook : Piece
    {
		public Rook(Position position, bool black, Image image, TableLayoutPanel panel)
			: base(position, black, image, panel)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
			// Une tour peut bouger suivant un unique axe
			return this.position.getX() == endPos.getX() || this.position.getY() == endPos.getY();
        }
    }
}
