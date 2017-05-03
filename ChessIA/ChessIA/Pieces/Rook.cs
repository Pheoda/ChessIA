using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Rook : Piece
    {
        public Rook(bool black) : base(black)
        {

        }

        public override bool canMove(Position endPos, Piece[] pieces)
        {

            if (this.position.getX() == endPos.getX())
            {
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
            // regarde si à la position d'arrivé on a bien une piece de la couleur différente
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

            // Une tour peut bouger suivant un unique axe
            return true;
        }
    }
}
