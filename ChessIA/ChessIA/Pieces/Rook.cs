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
		public Rook(Position position, bool black, Image image)
			: base(position, black, image)
        {

        }
		
		public override void setPossibleMoves(List<Piece> pieces)
		{
			possibleMoves.Clear();
			int xPiece = this.getPos().getX();
			int yPiece = this.getPos().getY();

			// NORD : y-
			for (int y = yPiece - 1; y >= 0; y--)
			{
				if (collide(new Position(xPiece, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach(Piece p in pieces)
					{
						if (p.getPos().getX() == xPiece && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(xPiece, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(xPiece, y), VALUE_EMPTY));
			}
			// SUD : y+
			for (int y = yPiece + 1; y < Chessboard.SIZE; y++)
			{
				if (collide(new Position(xPiece, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == xPiece && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(xPiece, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(xPiece, y), VALUE_EMPTY));
			}

			// OUEST : x-
			for (int x = xPiece - 1; x >= 0; x--)
			{
				if (collide(new Position(x, yPiece), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == yPiece)
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x, yPiece), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x, yPiece), VALUE_EMPTY));
			}

			// EST : x+
			for (int x = xPiece + 1; x < Chessboard.SIZE; x++)
			{
				if (collide(new Position(x, yPiece), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == yPiece)
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x, yPiece), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x, yPiece), VALUE_EMPTY));
			}
		}
	}
}
