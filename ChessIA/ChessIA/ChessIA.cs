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
        public ChessIA()
        {
            InitializeComponent();
        }

        private void ChessIA_Load(object sender, EventArgs e)
        {

        }

        private void chessboard_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column % 2 == 0))
            {

            }
        }
    }
}
