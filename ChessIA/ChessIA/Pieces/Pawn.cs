using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Pawn : Piece
    {
        private bool isFirstMove;

		public Pawn(Position position, bool black, Image image)
			: base(position, black, image)
        {
            isFirstMove = true;
        }
        public bool _isFirstMove {
            get
            {
                return isFirstMove;
            }
            set
            {
                isFirstMove = value;
            }
        }
        public override bool canMove(Position endPos, List<Piece> pieces)
        {
            if (this.isBlack)
            {
                //On regarde si le déplacement est effectué dans le bon sens
                if (endPos.getY() > this.getPos().getY())
                {
                    int offset = endPos.getY() - this.getPos().getY();

                    switch (offset)
                    {
                        case 1:
                            //check if not a diagonal move + no piece at endPos
                            if (this.getPos().getX() == endPos.getX())
                            {
                                foreach (Piece piece in pieces)
                                {
                                    if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == endPos.getY())
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }
                            //Diagonal move + check if ennemie
                            else if (Math.Abs(endPos.getX() - this.getPos().getX()) == 1)
                            {
                                foreach (Piece piece in pieces)
                                {
                                    if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == endPos.getY() && !piece.getIsBlack())
                                    {
                                        return true;
                                    }
                                }
                            }
                            break;

                        case 2:
                            //check if first move and no diag
                            if (this.isFirstMove && this.getPos().getX() == endPos.getX())
                            {
                                foreach (Piece piece in pieces)
                                {
                                    for (int i = this.getPos().getY() + 1; i <= endPos.getY(); i++)
                                    {
                                        if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == i)
                                        {
                                            return false;
                                        }
                                    }
                                }
                                return true;
                            }
                            break;

                        default:
                            return false;
                    }
                }
                return false;
            }
            else
            {
                //On regarde si le déplacement est effectué dans le bon sens
                if (endPos.getY() < this.getPos().getY())
                {
                    int offset = this.getPos().getY() - endPos.getY();

                    switch (offset)
                    {
                        case 1:
                            //check if not a diagonal move + no piece at endPos
                            if (this.getPos().getX() == endPos.getX())
                            {
                                foreach (Piece piece in pieces)
                                {
                                    if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == endPos.getY())
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }
                            //Diagonal move + check if ennemie
                            else if (Math.Abs(endPos.getX() - this.getPos().getX()) == 1)
                            {
                                foreach (Piece piece in pieces)
                                {
                                    if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == endPos.getY() && piece.getIsBlack())
                                    {
                                        return true;
                                    }
                                }
                            }
                            break;

                        case 2:
                            //check if first move and no diag
                            if (this.isFirstMove && this.getPos().getX() == endPos.getX())
                            {
                                foreach (Piece piece in pieces)
                                {
                                    for (int i = this.getPos().getY() - 1; i >= endPos.getY(); i--)
                                    {
                                        if (piece.getPos().getX() == endPos.getX() && piece.getPos().getY() == i)
                                        {
                                            return false;
                                        }
                                    }
                                }
                                return true;
                            }
                            break;

                        default:
                            return false;
                    }
                }
                return false;
            }
        }	
    }
}
