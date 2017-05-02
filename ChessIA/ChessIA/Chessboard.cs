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

		public static int SIZE = 8;
		
        public Chessboard(TableLayoutPanel panel)
        {
			pieces = new Piece[24];
			pieces[0] = new Rook(new Position(0, 0), true, "../../Images/noir_tour.png", panel);
			pieces[1] = new Bishop(new Position(2, 0), true, "../../Images/noir_fou.png", panel);
			pieces[2] = new King(new Position(4, 0), true, "../../Images/noir_roi.png", panel);
			pieces[3] = new Knight(new Position(6, 0), true, "../../Images/noir_cavalier.png", panel);

			pieces[4] = new Pawn(new Position(1, 1), true, "../../Images/noir_pion.png", panel);
			pieces[5] = new Pawn(new Position(3, 1), true, "../../Images/noir_pion.png", panel);
			pieces[6] = new Pawn(new Position(5, 1), true, "../../Images/noir_pion.png", panel);
			pieces[7] = new Pawn(new Position(7, 1), true, "../../Images/noir_pion.png", panel);

			pieces[8] = new Pawn(new Position(0, 2), true, "../../Images/noir_pion.png", panel);
			pieces[9] = new Pawn(new Position(2, 2), true, "../../Images/noir_pion.png", panel);
			pieces[10] = new Pawn(new Position(4, 2), true, "../../Images/noir_pion.png", panel);
			pieces[11] = new Pawn(new Position(6, 2), true, "../../Images/noir_pion.png", panel);


			pieces[12] = new Rook(new Position(0, 7), false, "../../Images/blanc_tour.png", panel);
			pieces[13] = new Bishop(new Position(2, 7), false, "../../Images/blanc_fou.png", panel);
			pieces[14] = new King(new Position(4, 7), false, "../../Images/blanc_roi.png", panel);
			pieces[15] = new Knight(new Position(6, 7), false, "../../Images/blanc_cavalier.png", panel);

			pieces[16] = new Pawn(new Position(1, 6), false, "../../Images/blanc_pion.png", panel);
			pieces[17] = new Pawn(new Position(3, 6), false, "../../Images/blanc_pion.png", panel);
			pieces[18] = new Pawn(new Position(5, 6), false, "../../Images/blanc_pion.png", panel);
			pieces[19] = new Pawn(new Position(7, 6), false, "../../Images/blanc_pion.png", panel);

			pieces[20] = new Pawn(new Position(0, 5), false, "../../Images/blanc_pion.png", panel);
			pieces[21] = new Pawn(new Position(2, 5), false, "../../Images/blanc_pion.png", panel);
			pieces[22] = new Pawn(new Position(4, 5), false, "../../Images/blanc_pion.png", panel);
			pieces[23] = new Pawn(new Position(6, 5), false, "../../Images/blanc_pion.png", panel);

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
				if (piece.getPos() == startPos)
				{
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
    }
}
