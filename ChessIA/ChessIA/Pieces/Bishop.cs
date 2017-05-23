using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Bishop : Piece
    {
		public Bishop(Position position, bool black, Image image)
			: base(position, black, image)
        {

        }

		/*public override bool canMove(Position endPos, List<Piece> pieces)
        {
			if (Math.Abs(this.getPos().getX() - endPos.getX()) == Math.Abs(this.getPos().getY() - endPos.getY())) // Déplacement en diagonal uniquement
			{
				// NORD (y-)
				if (endPos.getY() < this.getPos().getY())
					for (int y = 1; this.getPos().getY() - y > endPos.getY(); y++)
					{
						// NORD OUEST (- ; -)
						if (endPos.getX() < this.getPos().getX())
						{
							if (this.collide(new Position(this.getPos().getX() - y, this.getPos().getY() - y), pieces))
								return false;
						}
						// NORD EST (+ ; -)
						else
						{
							if (this.collide(new Position(this.getPos().getX() + y, this.getPos().getY() - y), pieces))
								return false;
						}
					}
				// SUD (y+)
				else
					for (int y = 1; this.getPos().getY() + y < endPos.getY(); y++)
					{
						// SUD OUEST (- ; +)
						if (endPos.getX() < this.getPos().getX())
						{
							if (this.collide(new Position(this.getPos().getX() - y, this.getPos().getY() + y), pieces))
								return false;
						}
						// SUD EST (+ ; +)
						else
						{
							if (this.collide(new Position(this.getPos().getX() + y, this.getPos().getY() + y), pieces))
								return false;
						}
					}

				// Pas de détection de pion sur le trajet
				// Vérification de la couleur de la pièce sur la case d'arrivée
				foreach (Piece piece in pieces)
				{
					if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY())
						return this.isBlack != piece.getIsBlack();
				}
				// Case libre
				return true;
			}
        }*/

		public override void setPossibleMoves(List<Piece> pieces)
		{
			possibleMoves.Clear();
			int x = position.getX(), y = position.getY();

			// NORD OUEST -/-
			for(int i = 1; isInChessboard(new Position(x - i, y - i)); i++)
			{
				if (collide(new Position(x - i, y - i), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == (x - i) && p.getPos().getY() == (y - i))
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x - i, y - i), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x - i, y - i), VALUE_EMPTY));
			}


			// NORD EST +/-
			for (int i = 1; isInChessboard(new Position(x + i, y - i)); i++)
			{
				if (collide(new Position(x + i, y - i), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == (x + i) && p.getPos().getY() == (y - i))
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x + i, y - i), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x + i, y - i), VALUE_EMPTY));
			}

			// SUD OUEST -/+
			for (int i = 1; isInChessboard(new Position(x - i, y + i)); i++)
			{
				if (collide(new Position(x - i, y + i), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == (x - i) && p.getPos().getY() == (y + i))
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x - i, y + i), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x - i, y + i), VALUE_EMPTY));
			}

			// SUD EST +/+
			for (int i = 1; isInChessboard(new Position(x + i, y + i)); i++)
			{
				if (collide(new Position(x + i, y + i), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == (x + i) && p.getPos().getY() == (y + i))
						{
							if (p.getIsBlack() != this.isBlack)
								this.possibleMoves.Add(new Move(new Position(x + i, y + i), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					this.possibleMoves.Add(new Move(new Position(x + i, y + i), VALUE_EMPTY));
			}
		}
	}
}
