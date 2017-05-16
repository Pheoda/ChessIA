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

		public override bool canMove(Position endPos, List<Piece> pieces)
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
			else
				return false; // Si déplacement pas diagonal
        }

		public override List<Move> possibleMoves(List<Piece> pieces)
		{
			throw new NotImplementedException();
		}
	}
}
