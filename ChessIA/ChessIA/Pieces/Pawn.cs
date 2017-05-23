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
		
		public override void setPossibleMoves(List<Piece> pieces)
		{
			possibleMoves.Clear();
            int j = 1;
            if (this._isFirstMove)
            {
                j = 2;
            }
            //déplacement standard (vertical)
            for (int i = 0; i < j; i++)
            {
                if (this.isBlack)
                {
                    int x = this.getPos().getX();
                    int y = this.getPos().getY() + (i + 1);
					if (this.isInChessboard(new Position(x, y)))
						if (!collide(new Position(x, y), pieces))
							this.possibleMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
						else
							break;
                }
                else
                {
                    int x = this.getPos().getX();
                    int y = this.getPos().getY() - (i + 1);
					if (this.isInChessboard(new Position(x, y)))
						if (!collide(new Position(x, y), pieces))
							this.possibleMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
						else
							break;
                }
            }

            //déplacement horizontal
            for (j = -1; j <= 1; j += 2)
            {
                for (int i = -1; i <= 1; i += 2)
                {
                    int x = this.getPos().getX() + i;
                    int y = this.getPos().getY() + j;

                    if (!((j > 0 && !this.isBlack) || (j < 0 && this.isBlack)))
						foreach (Piece piece in pieces)
						{
							if (piece.getPos().Equals(new Position(x, y)) && this.isBlack != piece.getIsBlack())
							{
								if (j < 0 && !this.isBlack)
								{
									this.possibleMoves.Add(new Move(new Position(x, y), getValue(piece)));
									break;
								}
								else if (j > 0 && this.isBlack)
								{
									this.possibleMoves.Add(new Move(new Position(x, y), getValue(piece)));
									break;
								}
							}
						}
                }
            }
		}
	}
}
