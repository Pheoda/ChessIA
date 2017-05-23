using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    public partial class ChessIA : Form
    {
		private Chessboard board;
		private bool selected;
		private Position startPos;

        public ChessIA()
        {
			InitializeComponent();
        }

        private void ChessIA_Load(object sender, EventArgs e)
        {
			for (int x = 0; x < Chessboard.SIZE; x++)
				for (int y = 0; y < Chessboard.SIZE; y++)
				{
					Panel p = new Panel();

					p.Tag = new Position(x, y);
					p.BackgroundImageLayout = ImageLayout.Stretch;
					p.Click += new EventHandler(panelClick);
					chessboard.Controls.Add(p, x, y);
				}

			board = new Chessboard(chessboard);

			selected = false;
        }

		private void panelClick(object sender, EventArgs e)
		{
			Position p = (Position)((Panel)sender).Tag;

			Piece pieceSelected = board.getPiece(p);

			if(!selected)
			{
				if (pieceSelected != null && pieceSelected.getIsBlack() == board.getTurn()) // Si on a cliqué sur une case contenant une pièce
				{
					selected = true;
					((Panel)sender).BackColor = Color.DeepSkyBlue;
					startPos = p;
					pieceSelected.displayPossibleMoves(board.getPieces(), chessboard);
				}
			}
			else
			{
				if(board.movePiece(startPos, p))
				{
					labelCheck.Text = "Echec : ";

					board.changeTurn();
					if (board.getTurn()) // Tour noir
						labelTurn.Text = "Noir";
					else
						labelTurn.Text = "Blanc";
					board.refresh();

					if (board.findKing(true).getInCheck(board.getPieces())) // TEST NOIR
					{
						labelCheck.Text = "NOIR  ";
					}
					if (board.findKing(false).getInCheck(board.getPieces())) // TEST BLANC
					{
						labelCheck.Text += "BLANC";
					}
					// Ajouter à la liste de coups les coordonnées x1;y1 -> x2;y2
					listMoves.Items.Add("(" + startPos.getX() + ";" + startPos.getY() + ") -> (" + p.getX() + ";" + p.getY() + ")");
					
					// Réinitialisation
					selected = false;
				}
				else if (pieceSelected != null && pieceSelected.getIsBlack() == board.getTurn()) // Sélection d'une autre pièce alors qu'on a déjà une pièce sélectionnée
				{
					((Panel)sender).BackColor = Color.DeepSkyBlue;
					startPos = p;
					pieceSelected.displayPossibleMoves(board.getPieces(), chessboard);
				}
			}
		}

		private void deplacementButton_Click(object sender, EventArgs e)
		{
			int x1, y1, x2, y2;

			// Piece de depart
			x1 = (int)inputX1.Value;
			y1 = (int)inputY1.Value;

			// Position d'arrivee
			x2 = (int)inputX2.Value;
			y2 = (int)inputY2.Value;

			//Console.WriteLine("Entree : {0}/{1} et {2}/{3}", x1, y1, x2, y2);

			if (board.movePiece(new Position(x1, y1), new Position(x2, y2))) // Mouvement possible
			{
				labelCheck.Text = "Echec : ";

				board.changeTurn();
				if (board.getTurn()) // Tour noir
					labelTurn.Text = "Noir";
				else
					labelTurn.Text = "Blanc";
				board.refresh();

				if(board.findKing(true).getInCheck(board.getPieces())) // TEST NOIR
				{
					labelCheck.Text = "NOIR  ";
				}
				if (board.findKing(false).getInCheck(board.getPieces())) // TEST BLANC
				{
					labelCheck.Text += "BLANC";
				}
				// Ajouter à la liste de coups les coordonnées x1;y1 -> x2;y2
				listMoves.Items.Add("(" + x1 + ";" + y1 + ") -> (" + x2 + ";" + y2 + ")");
			}
		}

        private void inputX1_Enter(object sender, EventArgs e)
        {
            inputX1.Select(0, 1);
        }
        private void inputY1_Enter(object sender, EventArgs e)
        {
            inputY1.Select(0, 1);
        }
        private void inputX2_Enter(object sender, EventArgs e)
        {
            inputX2.Select(0, 1);
        }
        private void inputY2_Enter(object sender, EventArgs e)
        {
            inputY2.Select(0, 1);
        }
	}
}
