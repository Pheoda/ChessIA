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

			board = new Chessboard();

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

		private void chessboard_Click(object sender, EventArgs e)
		{
			board.keyboardInput();
		}
    }
}
