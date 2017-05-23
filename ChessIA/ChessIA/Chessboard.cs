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
    class Chessboard
    {
		private List<Piece> pieces;
		private bool turn;
        private TableLayoutPanel layoutPanel;

		public static int SIZE = 8;
		
        public Chessboard(TableLayoutPanel panel)
        {
            layoutPanel = panel;

			pieces = new List<Piece>();
			pieces.Add(new Rook(new Position(0, 0), true, Properties.Resources.noir_tour));
			pieces.Add(new Bishop(new Position(2, 0), true, Properties.Resources.noir_fou));
			pieces.Add(new King(new Position(4, 0), true, Properties.Resources.noir_roi));
			pieces.Add(new Knight(new Position(6, 0), true, Properties.Resources.noir_cavalier));

			pieces.Add(new Pawn(new Position(1, 1), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(3, 1), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(5, 1), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(7, 1), true, Properties.Resources.noir_pion));

			pieces.Add(new Pawn(new Position(0, 2), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(2, 2), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(4, 2), true, Properties.Resources.noir_pion));
			pieces.Add(new Pawn(new Position(6, 2), true, Properties.Resources.noir_pion));


			pieces.Add(new Rook(new Position(0, 7), false, Properties.Resources.blanc_tour));
			pieces.Add(new Bishop(new Position(2, 7), false, Properties.Resources.blanc_fou));
			pieces.Add(new King(new Position(4, 7), false, Properties.Resources.blanc_roi));
			pieces.Add(new Knight(new Position(6, 7), false, Properties.Resources.blanc_cavalier));

			pieces.Add(new Pawn(new Position(1, 6), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(3, 6), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(5, 6), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(7, 6), false, Properties.Resources.blanc_pion));

			pieces.Add(new Pawn(new Position(0, 5), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(2, 5), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(4, 5), false, Properties.Resources.blanc_pion));
			pieces.Add(new Pawn(new Position(6, 5), false, Properties.Resources.blanc_pion));

			turn = false; // Tour des blancs au démarrage

			refresh();
        }

		// Bouge la piece si possible suivant la saisie clavier precedente
		public bool movePiece(Position startPos, Position endPos)
		{
			Piece piece = getPiece(startPos);
			if (piece != null)
			{

				refresh();

				if (piece.getIsBlack() != this.turn) // On s'assure que la couleur jouée est bien la bonne
				{
					refresh();
					return false;
				}
				else // Si le déplacement est correct, on déplace ou on mange la pièce ciblée
				{
					bool pieceMoved = piece.canMove(endPos, this.pieces);

					if (pieceMoved) // Déplacement valide
					{
						Piece needDelete = null;
						if (piece.GetType() == typeof(Pawn))
						{
							Pawn pawn = (Pawn)piece;
							pawn._isFirstMove = false;
						}

						// Vérification s'il s'agit d'une prise de pièce
						foreach (Piece p in pieces)
						{
							if (p.getPos().getX() == endPos.getX() && p.getPos().getY() == endPos.getY()) // On mange
							{
								needDelete = p;
							}
						}
						if (needDelete != null) // Si on a mangé une pièce, on la supprime de la liste
							pieces.Remove(needDelete);

						// Suppression sprite sur l'ancienne case
						layoutPanel.GetControlFromPosition(piece.getPos().getX(), piece.getPos().getY()).BackgroundImage = null;

						// On déplace la pièce à la position finale
						piece.setPos(endPos);
						updatePossibleMoves(); // MAJ des mouvements possibles
					}

					return pieceMoved;
				}
			}
			return false;
		}

		public void changeTurn()
		{
			this.turn = !this.turn;
		}
		public bool getTurn()
		{
			return this.turn;
		}

		public List<Piece> getPieces()
		{
			return pieces;
		}

		// Une pièce est-elle sur la case ?
		public Piece getPiece(Position p)
		{
			foreach (Piece piece in pieces)
				if (piece.getPos().getX().Equals(p.getX()) && piece.getPos().getY().Equals(p.getY()))
					return piece;
			return null;
		}

		public King findKing(bool isBlack)
		{
			foreach(Piece p in pieces)
			{
				if (p.GetType() == typeof(King))
					if (p.getIsBlack() == isBlack) // Même couleur que demandé
						return (King)p;
			}
			return null;
		}

		public bool checkMate(King k)
		{
			return k.getInCheck(pieces) && k.getPossibleMoves().Count == 0; // Le roi est en échec et ne peut pas effectuer de déplacement
		}

		public void updatePossibleMoves()
		{
			foreach(Piece p in pieces)
				p.setPossibleMoves(pieces);
		}

        public void refresh()
        {
			for (int x = 0; x < Chessboard.SIZE; x++)
				for (int y = 0; y < Chessboard.SIZE; y++ )
					if ((x + y) % 2 == 0)
						layoutPanel.GetControlFromPosition(x, y).BackColor = Color.WhiteSmoke;
					else
						layoutPanel.GetControlFromPosition(x, y).BackColor = Color.DarkGray;

            foreach(Piece p in pieces)
				layoutPanel.GetControlFromPosition(p.getPos().getX(), p.getPos().getY()).BackgroundImage = p.getImage();
        }
    }
}
