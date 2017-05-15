using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Knight : Piece
    {
		public Knight(Position position, bool black, Image image)
			: base(position, black, image)
        {

        }

		public override bool canMove(Position endPos, List<Piece> pieces)
        {
            int dist = (endPos.getX() - this.getPos().getX()) * (endPos.getX() - this.getPos().getX()) + (endPos.getY() - this.getPos().getY()) * (endPos.getY() - this.getPos().getY());
            if (dist == 5)
            {

                foreach (Piece piece in pieces)
                {
                    if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                    {
                        return true;
                    }
                    if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack == piece.getIsBlack())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

		public override List<Move> possibleMoves(List<Piece> pieces)
		{
			throw new NotImplementedException();
		}
	}
}
