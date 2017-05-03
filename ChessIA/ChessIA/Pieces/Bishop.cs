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
		public Bishop(Position position, bool black, Image image, TableLayoutPanel panel)
			: base(position, black, image, panel)
        {

        }

		public override bool canMove(Position endPos, Piece[] pieces)
        {
            if (Math.Abs(endPos.getX() - this.getPos().getX()) < 0 && Math.Abs(endPos.getY() - this.getPos().getY()) < 0)
            {
                foreach(Piece piece in pieces)
                {
                    if ((endPos.getX() - this.getPos().getX()) > 0 && (endPos.getY() - this.getPos().getY()) > 0)
                    {
                        for (int x = this.getPos().getX() + 1, y = this.getPos().getY() + 1; x < endPos.getX() && y < endPos.getY(); x++, y++)
                        {
                            if (piece.getPos().getY() == y && piece.getPos().getX() == x)
                            {
                                return false;
                            }
                        }
                    }
                    if ((endPos.getX() - this.getPos().getX()) < 0 && (endPos.getY() - this.getPos().getY()) > 0)
                    {
                        for (int x = this.getPos().getX() - 1, y = this.getPos().getY() + 1; x < endPos.getX() && y < endPos.getY(); x--, y++)
                        {
                            if (piece.getPos().getY() == y && piece.getPos().getX() == x)
                            {
                                return false;
                            }
                        }
                    }
                    if ((endPos.getX() - this.getPos().getX()) > 0 && (endPos.getY() - this.getPos().getY()) < 0)
                    {
                        for (int x = this.getPos().getX() + 1, y = this.getPos().getY() - 1; x < endPos.getX() && y < endPos.getY(); x++, y--)
                        {
                            if (piece.getPos().getY() == y && piece.getPos().getX() == x)
                            {
                                return false;
                            }
                        }
                    }
                    if ((endPos.getX() - this.getPos().getX()) < 0 && (endPos.getY() - this.getPos().getY()) < 0)
                    {
                        for (int x = this.getPos().getX() - 1, y = this.getPos().getY() - 1; x < endPos.getX() && y < endPos.getY(); x--, y--)
                        {
                            if (piece.getPos().getY() == y && piece.getPos().getX() == x)
                            {
                                return false;
                            }
                        }
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
    }
}
