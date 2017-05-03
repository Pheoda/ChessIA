﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class Knight : Piece
    {
		public Knight(Position position, bool black, Image image)
			: base(position, black, image)
        {

        }

		public override bool canMove(Position endPos, List<Piece> pieces)
        {
            foreach (Piece piece in pieces)
            {
                if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack != piece.getIsBlack())
                {
                    return true;
                }
                if (endPos.getX() == piece.getPos().getX() && endPos.getY() == piece.getPos().getY() && this.isBlack == piece.getIsBlack())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
