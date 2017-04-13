using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessIA
{
    class Chessboard
    {
		private Piece[] pieces;

		public static int SIZE = 8;
		
        public Chessboard()
        {
			pieces = new Piece[24];
        }

		public void keyboardInput()
		{
			int x1, y1, x2, y2;

			do
			{
				Console.WriteLine("Entrer position de depart : ");
				// Saisie piece de depart
				x1 = safeInput(0, SIZE);
				y1 = safeInput(0, SIZE);

				Console.WriteLine("Entrer position d'arrivee : ");
				// Saisie position d'arrivee
				x2 = safeInput(0, SIZE);
				y2 = safeInput(0, SIZE);

				Console.WriteLine("Entree : {0}/{1} et {2}/{3}", x1, y1, x2, y2);
				
			}while(!movePiece(new Position(x1, y1), new Position(x2, y2)));
		}

		// Renvoie la saisie clavier avec conditions min/max
		private int safeInput(int min, int max)
		{
			int result;
			do
			{
				while (!Int32.TryParse(Console.ReadLine(), out result)) ; // Tant qu'on a pas recuperer un entier
			}while(result < min || result > max);

			return result;
		}

		// Bouge la piece si possible suivant la saisie clavier precedente
		public bool movePiece(Position startPos, Position endPos)
		{
			return true;
		}

		// Est-ce que la piece p peut se deplacer a la position newPos ?
		public bool checkDeplacement(Piece p, Position newPos)
		{
			return true;
		}


    }
}
