using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChessIA
{
    class Chessboard
    {
		private Piece[] pieces;
		private bool turn;
        private TableLayoutPanel layoutPanel;

		public static int SIZE = 8;
		
        public Chessboard(TableLayoutPanel panel)
        {
            layoutPanel = panel;

			pieces = new Piece[24];
			pieces[0] = new Rook(new Position(0, 0), true, Properties.Resources.noir_tour, panel);
			pieces[1] = new Bishop(new Position(2, 0), true, Properties.Resources.noir_fou, panel);
			pieces[2] = new King(new Position(4, 0), true, Properties.Resources.noir_roi, panel);
			pieces[3] = new Knight(new Position(6, 0), true, Properties.Resources.noir_cavalier, panel);

			pieces[4] = new Pawn(new Position(1, 1), true, Properties.Resources.noir_pion, panel);
			pieces[5] = new Pawn(new Position(3, 1), true, Properties.Resources.noir_pion, panel);
			pieces[6] = new Pawn(new Position(5, 1), true, Properties.Resources.noir_pion, panel);
			pieces[7] = new Pawn(new Position(7, 1), true, Properties.Resources.noir_pion, panel);

			pieces[8] = new Pawn(new Position(0, 2), true, Properties.Resources.noir_pion, panel);
			pieces[9] = new Pawn(new Position(2, 2), true, Properties.Resources.noir_pion, panel);
			pieces[10] = new Pawn(new Position(4, 2), true, Properties.Resources.noir_pion, panel);
			pieces[11] = new Pawn(new Position(6, 2), true, Properties.Resources.noir_pion, panel);


			pieces[12] = new Rook(new Position(0, 7), false, Properties.Resources.blanc_tour, panel);
			pieces[13] = new Bishop(new Position(2, 7), false, Properties.Resources.blanc_fou, panel);
			pieces[14] = new King(new Position(4, 7), false, Properties.Resources.blanc_roi, panel);
			pieces[15] = new Knight(new Position(6, 7), false, Properties.Resources.blanc_cavalier, panel);

			pieces[16] = new Pawn(new Position(1, 6), false, Properties.Resources.blanc_pion, panel);
			pieces[17] = new Pawn(new Position(3, 6), false, Properties.Resources.blanc_pion, panel);
			pieces[18] = new Pawn(new Position(5, 6), false, Properties.Resources.blanc_pion, panel);
			pieces[19] = new Pawn(new Position(7, 6), false, Properties.Resources.blanc_pion, panel);

			pieces[20] = new Pawn(new Position(0, 5), false, Properties.Resources.blanc_pion, panel);
			pieces[21] = new Pawn(new Position(2, 5), false, Properties.Resources.blanc_pion, panel);
			pieces[22] = new Pawn(new Position(4, 5), false, Properties.Resources.blanc_pion, panel);
			pieces[23] = new Pawn(new Position(6, 5), false, Properties.Resources.blanc_pion, panel);

            refresh();

			turn = false; // Tour des blancs au demarrage
        }

		// Saisie clavier
		public void keyboardInput()
		{
			int x1, y1, x2, y2;

			do
			{
				Console.WriteLine("Entrer position de depart : ");
				// Saisie piece de depart
				x1 = safeInput(0, SIZE-1);
				y1 = safeInput(0, SIZE-1);

				Console.WriteLine("Entrer position d'arrivee : ");
				// Saisie position d'arrivee
				x2 = safeInput(0, SIZE-1);
				y2 = safeInput(0, SIZE-1);

				Console.WriteLine("Entree : {0}/{1} et {2}/{3}", x1, y1, x2, y2);
				
			}while(!movePiece(new Position(x1, y1), new Position(x2, y2)));
		}

		// Renvoie la saisie clavier avec conditions min/max
		private int safeInput(int min, int max)
		{
			int result;
			do
			{
				while (!Int32.TryParse(Console.ReadLine(), out result)) ; // Tant qu'on a pas recupere un entier
			}while(result < min || result > max);

			return result;
		}

		// Bouge la piece si possible suivant la saisie clavier precedente
		public bool movePiece(Position startPos, Position endPos)
		{
			foreach(Piece piece in pieces)
			{
				if (piece.getPos().getX() == startPos.getX() && piece.getPos().getY() == startPos.getY())
				{
					if(piece.getIsBlack() != this.turn) // On s'assure que la couleur jouee est bien la bonne
					{
						Console.WriteLine("Ce n'est pas à cette couleur de jouer !");
						return false;
					}
					else
						return piece.move(endPos, this.pieces);
				}
			}
			Console.WriteLine("Piece non trouvee");
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
        public void refresh()
        {
            foreach(Piece p in pieces)
            {
                layoutPanel.SetCellPosition(p.getPicture(), new TableLayoutPanelCellPosition(p.getPos().getX(), p.getPos().getY()));
            }
        }
    }
}
