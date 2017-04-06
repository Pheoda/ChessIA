using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    abstract class Piece
    {
        private bool isBlack;

		public Piece(bool black)
		{
			isBlack = black;
		}

        public abstract void move();

		public bool getIsBlack()
		{
			return isBlack;
		}
    }
}
