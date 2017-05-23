using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class King : Piece
    {
		private bool isFirstMove;
		private bool inCheck;

		public King(Position position, bool black, Image image)
			: base(position, black, image)
        {
			isFirstMove = true;
			inCheck = false;
        }

		/*public override bool canMove(Position endPos, List<Piece> pieces)
        {
            if (Math.Abs(this.getPos().getX() - endPos.getX()) < 2 && Math.Abs(this.getPos().getY() - endPos.getY()) < 2)
            {
                foreach(Piece piece in pieces)
                {
                    if (piece.getPos().getY() == endPos.getY() && piece.getPos().getX() == endPos.getX() && this.isBlack != piece.getIsBlack())
                    {
                        return true;
                    }
                    if (piece.getPos().getY() == endPos.getY() && piece.getPos().getX() == endPos.getX() && this.isBlack == piece.getIsBlack())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }*/


		public bool getInCheck(List<Piece> pieces)
		{
			int x = this.getPos().getX(), y = this.getPos().getY();
			foreach(Piece p in pieces)
			{
				if(p.getIsBlack() != this.getIsBlack() && p.GetType() != typeof(King)) // Si une pièce adverse différente du roi
					if (p.canMove(new Position(x, y), pieces)) // Peut aller à la position du roi
						return true;							// On a une position d'échec
			}

			return false;
		}

		public override void setPossibleMoves(List<Piece> pieces)
		{
			possibleMoves.Clear();
			int x, y;

            for (int i = -1; i < 2; i++)
			    for (int j = -1; j < 2; j++)
					if (i != 0 || j != 0)
					{
						x = this.getPos().getX() + i;
						y = this.getPos().getY() + j;
                        if (isInChessboard(new Position(x, y)))
                        {
							if (!(collide(new Position(x, y), pieces)))
							{
								this.possibleMoves.Add(new Move(new Position(x, y), VALUE_EMPTY));
							}
							else
								foreach (Piece piece in pieces)
									if (piece.getPos().Equals(new Position(x, y)) && this.isBlack != piece.getIsBlack())
									{
										this.possibleMoves.Add(new Move(new Position(x, y), getValue(piece)));
									}
                        }
					}

			x = this.getPos().getX();
			y = this.getPos().getY();
			// On enlève les positions où le roi est en échec
			for(int i = 0; i < possibleMoves.Count; i++)
			{
				this.setPos(possibleMoves[i].getPosition());
				Console.WriteLine("New pos : " + getPos().getX() + "/" + getPos().getY());
				if (this.getInCheck(pieces))
				{
					Console.WriteLine("^-POSITION ECHEC");
					possibleMoves.Remove(possibleMoves[i]);
				}
			}
			this.setPos(new Position(x, y));
		}
	}
}
