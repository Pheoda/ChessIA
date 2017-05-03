using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class King : Piece
    {
		private bool isFirstMove;

		public King(Position position, bool black, Image image, TableLayoutPanel panel)
			: base(position, black, image, panel)
        {
			isFirstMove = true;
        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            if (Math.Abs(this.getPos().getX() - endPos.getX()) < 2 && Math.Abs(this.getPos().getY() - endPos.getY()) < 2)
            {
                foreach(Piece piece in pieces)
                {
                    if (piece.getPos().getY() == endPos.getY() && piece.getPos().getX() == endPos.getX() && this.isBlack != piece.getIsBlack())
                    {
                        return true;
                    }
                    if (piece.getPos().getY() == endPos.getY() && piece.getPos().getX() == endPos.getX() && this.isBlack == piece.getIsBlack())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
