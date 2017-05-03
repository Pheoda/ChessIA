using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Pawn : Piece
    {
        private bool isFirstMove;

        public Pawn(bool black) : base(black)
        {
            isFirstMove = true;
        }

        public override bool canMove(Position endPos, Piece[] pieces)
        {

            if (this.isBlack)
            {
                // déplacement en diagonale
                if ((this.position.getY() + 1) == endPos.getY())
                {
                    if ((endPos.getX() == (this.position.getX() + 1)) || (endPos.getX() == (this.position.getX() - 1)))
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;
                }
                // premier déplacement 1 ou 2 cases en avant
                if (this.isFirstMove)
                {
                    if (this.position.getX() == endPos.getX() && (endPos.getY() - this.position.getY()) > 0 && (endPos.getY() - this.position.getY()) < 3)
                    {
                        for (int i = this.position.getY() + 1; i <= endPos.getY(); i++)
                        {
                            foreach (Piece piece in pieces)
                            {
                                if ((i == piece.getPos().getY()) && (endPos.getX() == piece.getPos().getX()))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
                // déplacement standard
                else
                {
                    if (this.position.getX() == endPos.getX() && (endPos.getY() - this.position.getY()) > 0 && (endPos.getY() - this.position.getY()) < 2)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (((this.position.getY() + 1) == piece.getPos().getY()) && (endPos.getX() == piece.getPos().getX()))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                }
            }
            else
            {
                // déplacement en diagonale
                if ((this.position.getY() - 1) == endPos.getY())
                {
                    if ((endPos.getX() == (this.position.getX() + 1)) || (endPos.getX() == (this.position.getX() - 1)))
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;
                }
                // premier déplacement 1 ou 2 cases en avant
                if (this.isFirstMove)
                {
                    if (this.position.getX() == endPos.getX() && (endPos.getY() - this.position.getY()) < 0 && (this.position.getY() - endPos.getY()) < 3)
                    {
                        for (int i = this.position.getY() - 1; i >= endPos.getY(); i--)
                        {
                            foreach (Piece piece in pieces)
                            {
                                if ((i == piece.getPos().getY()) && (endPos.getX() == piece.getPos().getX()))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
                // déplacement standard
                else
                {
                    if (this.position.getX() == endPos.getX() && (endPos.getY() - this.position.getY()) < 0 && (this.position.getY() - endPos.getY()) < 2)
                    {
                        foreach (Piece piece in pieces)
                        {
                            if (((this.position.getY() - 1) == piece.getPos().getY()) && (endPos.getX() == piece.getPos().getX()))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
            throw new NotImplementedException();

        }
    }
}
