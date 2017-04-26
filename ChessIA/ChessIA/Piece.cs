using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    abstract class Piece
    {
		protected Position position;
		protected bool isBlack;

		public Piece(bool black)
		{
			isBlack = black;
		}

		// Bouge la piece a la position pos en effectuant les tests necessaires
        public bool move(Position pos, Piece[] pieces)
		{
			if(canMove(pos, pieces))
			{
				return true;
			}
			else
			{
				Console.WriteLine("Impossible move for this piece");
				return false;
			}
		}
		
		// Est-ce que la piece peut se deplacer vers endPos ?
		public abstract bool canMove(Position endPos, Piece[] pieces);

		public bool getIsBlack()
		{
			return isBlack;
		}
		public Position getPos()
		{
			return position;
		}
    }
}
