using System;
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

		public override void setPossibleMoves(List<Piece> pieces)
		{
			possibleMoves.Clear();
            List<Position> allPos = new List<Position>();
            int x, y;

            //On place toutes les positions possibles dans une liste
            for (int i = -2; i < 3; i++)
            {
                for (int j = -2; j < 3; j++)
                {
					x = this.getPos().getX() + i;
					y = this.getPos().getY() + j;

					if (isInChessboard(new Position(x, y)))
					{
						int dist = (x - this.getPos().getX()) * (x - this.getPos().getX()) + (y - this.getPos().getY()) * (y - this.getPos().getY());
						if (dist == 5)
						{
							allPos.Add(new Position(x, y));
						}
					}
                }
            }

            foreach (Position pos2Test in allPos)
            {
                foreach (Piece piece in pieces)
                {
                    if (pos2Test.Equals(piece.getPos()) && piece.getIsBlack() != this.isBlack)
                    {
						this.possibleMoves.Add(new Move(pos2Test, getValue(piece)));
                    }
                }
                this.possibleMoves.Add(new Move(pos2Test, VALUE_EMPTY));
            }
    	}
	}
}
