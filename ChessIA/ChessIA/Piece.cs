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
		protected const double VALUE_EMPTY = 0;
		protected const double VALUE_PAWN = 1;
		protected const double VALUE_KNIGHT = 3.2;
		protected const double VALUE_BISHOP = 3.33;
		protected const double VALUE_ROOK = 5.1;
		protected const double VALUE_KING = 99999;

		protected Position position;
		protected bool isBlack;
		protected Image image;

		protected List<Move> possibleMoves;

		public Piece(Position position, bool black, Image image)
		{
			this.position = position;
			this.isBlack = black;
			this.image = image;
			this.possibleMoves = new List<Move>();
		}

		//public abstract bool canMove(Position endPos, List<Piece> pieces);

		// Renvoie si la pièce peut se déplacer à la position donnée
		public bool canMove(Position endPos, List<Piece> pieces)
		{
			setPossibleMoves(pieces); // MAJ de la liste des mouvements possibles

			return isPositionPossible(endPos);
		}

        // Calcul tous les coups possibles de la pièce
        public abstract void setPossibleMoves(List<Piece> pieces);

		public bool isPositionPossible(Position pos)
		{
			foreach (Move m in this.possibleMoves)
				if (m.getPosition().getX() == pos.getX() && m.getPosition().getY() == pos.getY())
					return true;

			return false;
		}

		public List<Move> getPossibleMoves()
		{
			return possibleMoves;
		}

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

		protected bool isInChessboard(Position pos)
		{
			return (pos.getX() >= 0) && (pos.getY() >= 0) && (pos.getX() < Chessboard.SIZE) && (pos.getY() < Chessboard.SIZE);
		}

		protected bool collide(Position pos, List<Piece> pieces) // Retourne s'il y a une pièce sur cette position
		{
			foreach (Piece piece in pieces)
				if (piece.getPos().getX() == pos.getX() && piece.getPos().getY() == pos.getY())
					return true;
			return false;
		}
		
		protected double getValue(Piece p)
		{
			if (p.GetType() == typeof(Pawn))
				return VALUE_PAWN;
			else if (p.GetType() == typeof(Knight))
				return VALUE_KNIGHT;
			else if (p.GetType() == typeof(Bishop))
				return VALUE_BISHOP;
			else if (p.GetType() == typeof(Rook))
				return VALUE_ROOK;
			else // King
				return VALUE_KING;
		}
    }
}
