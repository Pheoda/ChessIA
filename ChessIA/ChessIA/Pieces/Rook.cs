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
                for (int i = this.position.getX(); i < endPos.getX(); i++)
                {
                    foreach (Piece piece in pieces)
                    {
                        if (piece.getPos().getX() == i && piece.getPos().getY() == this.getPos().getY())
                        {
                            return false;
                        }
                    }
                }

                if (endPos.getY() - this.position.getY() > 0)
                {
                    for (int i = (this.position.getY() + 1); i < endPos.getY(); i++)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (piece.getPos().getY() == i)
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = (this.position.getY() + 1); i > endPos.getY(); i--)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (piece.getPos().getY() == i)
                            {
                                return false;
                            }
                        }

                    }
                }
            }
            else if (this.position.getY() == endPos.getY())
            {
                //on regarde si il n'y a pas de pions sur le trajet 
                for (int i = this.position.getY(); i < endPos.getY(); i++)
                {
                    foreach (Piece piece in pieces)
                    {
                        if (piece.getPos().getX() == i && piece.getPos().getY() == this.getPos().getY())
                        {
                            return false;
                        }
                    }
                }

                if ((endPos.getX() - this.position.getX()) > 0)
                {
                    for (int i = (this.position.getX() + 1); i < endPos.getX(); i++)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (piece.getPos().getX() == i)
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = (this.position.getX() + 1); i > endPos.getX(); i--)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (piece.getPos().getX() == i)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            // le déplacement voulu ne correspond pas au déplecement d'une tour
            else
            {
                return false;
            }
            // regarde si à la position d'arrivée on a bien une piece de la couleur différente
            foreach (Piece piece in pieces)
            {
                if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                {
                    return true;
                }
                else if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack == piece.getIsBlack())
                {
                    return false;
                }

            }

            return true;
        }

		public override List<Move> possibleMoves(List<Piece> pieces)
		{
			throw new NotImplementedException();
		}
	}
}
