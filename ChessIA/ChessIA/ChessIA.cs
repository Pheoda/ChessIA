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

        public ChessIA()
        {
            InitializeComponent();

			board = new Chessboard(chessboard);

        }

        private void ChessIA_Load(object sender, EventArgs e)
        {

        }

        private void chessboard_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row ) % 2 == 0 )
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Brown, e.CellBounds);
            }
        }

		private void deplacementButton_Click(object sender, EventArgs e)
		{
			int x1, y1, x2, y2;

			// Check non vide
			/*if(inputX1.Value == String.Empty || inputY1.Value == String.Empty 
				|| inputX2.Value == String.Empty || inputY2.Value == String.Empty)
				return;*/

			// Piece de depart
			x1 = (int)inputX1.Value;
			y1 = (int)inputY1.Value;

			// Position d'arrivee
			x2 = (int)inputX2.Value;
			y2 = (int)inputY2.Value;

			Console.WriteLine("Entree : {0}/{1} et {2}/{3}", x1, y1, x2, y2);

			if (board.movePiece(new Position(x1, y1), new Position(x2, y2)))
			{
				board.changeTurn();
				if (board.getTurn()) // Tour noir
					labelTurn.Text = "Noir";
				else
					labelTurn.Text = "Blanc";
				board.refresh();
			}
		}
    }
}
