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
		private bool inCheck;

		public King(Position position, bool black, Image image)
			: base(position, black, image)
        {
			isFirstMove = true;
			inCheck = false;
        }

		public override bool canMove(Position endPos, List<Piece> pieces)
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

		public bool _inCheck
		{
			get
			{
				return inCheck;
			}
			set
			{
				inCheck = value;
			}
		}

		public override List<Move> setPossibleMoves(List<Piece> pieces)
		{
            List<Move> validMove = new List<Move>();
			int x, y;

            for (int i = -1; i < 2; i++)
			{
			    for (int j = -1; j < 2; j++)
			    {
					if (i != 0 || j != 0)
					{
						x = this.getPos().getX() + i;
						y = this.getPos().getY() + j;
                        if (x >= 0 && y >= 0 && x < Chessboard.SIZE && y < Chessboard.SIZE)
                        {
                            if (!(collide(new Position(x, y), pieces)))
                            {
                                validMove.Add(new Move(new Position(x, y), VALUE_EMPTY));
                                continue;
                            }
                            foreach (Piece piece in pieces)
                            {
                                if (piece.getPos().Equals(new Position(x, y)) && this.isBlack != piece.getIsBlack())
                                {
                                    validMove.Add(new Move(new Position(x, y), getValue(piece)));
                                }
                            }
                        }
					}
			    }
			}
            return validMove;
		}
	}
}
