using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    abstract class Piece
    {
		protected Position position;
		protected bool isBlack;
		protected Image image;

		public Piece(Position position, bool black, Image image)
		{
			this.position = position;
			this.isBlack = black;
			this.image = image;
		}

		// Bouge la piece a la position pos en effectuant les tests necessaires
		public abstract bool canMove(Position endPos, List<Piece> pieces);

        // Calcul tous les coups possibles
        public abstract List<Move> possibleMoves(List<Piece> pieces);

		public bool getIsBlack()
		{
			return isBlack;
		}
		public Position getPos()
		{
			return position;
		}
		public void setPos(Position pos)
		{
			this.position = pos;
		}
		public Image getImage()
		{
			return this.image;
		}
		protected bool collide(Position pos, List<Piece> pieces) // Retourne s'il y a une pieces sur cette position
		{
			foreach (Piece piece in pieces)
				if (piece.getPos().getX() == pos.getX() && piece.getPos().getY() == pos.getY())
					return true;
			return false;
		}
    }
}
