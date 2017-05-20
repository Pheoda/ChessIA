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

		public override bool canMove(Position endPos, List<Piece> pieces)
        {		
            if (this.position.getX() == endPos.getX())
            {
                //on regarde si il n'y a pas de pions sur le trajet

                if (endPos.getY() > this.position.getY()) // y positif
                {
					for (int i = this.position.getY() + 1; i < endPos.getY(); i++)
						if (collide(new Position(endPos.getX(), i), pieces))
							return false;
                }
                else	// y négatif
                {
                    for (int i = this.position.getY() - 1; i > endPos.getY(); i--)
						if (collide(new Position(endPos.getX(), i), pieces))
                                return false;
                }
            }
            else if (this.position.getY() == endPos.getY())
            {
                //on regarde si il n'y a pas de pions sur le trajet

                if (endPos.getX() > this.position.getX()) // x positif
                {
                    for (int i = this.position.getX() + 1; i < endPos.getX(); i++)
						if (collide(new Position(i, endPos.getY()), pieces))
                                return false;
                }
                else	// x négatif
                {
                    for (int i = this.position.getX() - 1; i > endPos.getX(); i--)
						if (collide(new Position(i, endPos.getY()), pieces))
                                return false;
                }
            }
            // le déplacement voulu ne correspond pas à un déplacement sur un unique axe
            else
            {
                return false;
            }

            // regarde si à la position d'arrivée on a bien une piece de la couleur différente
            foreach (Piece piece in pieces)
            {
				if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY())
					return this.isBlack != piece.getIsBlack();
            }

			// Si la case est libre
            return true;
        }

		public override List<Move> possibleMoves(List<Piece> pieces)
		{
			List<Move> validMoves = new List<Move>();
			int x = this.getPos().getX();
			int y = this.getPos().getY();

			// NORD : y-
			for (y = y - 1; y >= 0; y--)
			{
				if (collide(new Position(x, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach(Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								validMoves.Add(new Move(new Position(x, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					validMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
			}
			// SUD : y+
			for (y = y + 1; y < Chessboard.SIZE; y++)
			{
				if (collide(new Position(x, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								validMoves.Add(new Move(new Position(x, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					validMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
			}

			// OUEST : x-
			for (x = x - 1; x >= 0; x--)
			{
				if (collide(new Position(x, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								validMoves.Add(new Move(new Position(x, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					validMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
			}

			// EST : x+
			for (x = x + 1; x < Chessboard.SIZE; x++)
			{
				if (collide(new Position(x, y), pieces))
				{
					// On regarde si on peut manger la pièce
					foreach (Piece p in pieces)
					{
						if (p.getPos().getX() == x && p.getPos().getY() == y)
						{
							if (p.getIsBlack() != this.isBlack)
								validMoves.Add(new Move(new Position(x, y), getValue(p)));
							break;
						}
					}
					break; // On sort une fois qu'on a atteint une pièce
				}
				else
					validMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
			}

			return validMoves;
		}
	}
}
