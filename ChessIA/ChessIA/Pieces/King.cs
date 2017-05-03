using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessIA
{
    class King : Piece
    {
		private bool isFirstMove;

		public King(Position position, bool black, Image image)
			: base(position, black, image)
        {
			isFirstMove = true;
        }

		public override bool canMove(Position endPos, List<Piece> pieces)
        {
            throw new NotImplementedException();
        }
    }
}
