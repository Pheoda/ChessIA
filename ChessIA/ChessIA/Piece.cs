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
		protected Position position;
		protected bool isBlack;
		protected PictureBox picture;

		public Piece(Position position, bool black, Image image, TableLayoutPanel parentPanel)
		{
			this.position = position;
			this.isBlack = black;
			this.picture = new PictureBox();
			picture.Image = image;
			picture.Parent = parentPanel;
            int size = (int)parentPanel.Size.Height / (int)parentPanel.ColumnCount;
            picture.Size = new Size(new Point(size, size));
			picture.BackColor = Color.Transparent;
		}

		// Bouge la piece a la position pos en effectuant les tests necessaires
        public bool move(Position pos, Piece[] pieces)
		{
			if(canMove(pos, pieces))
			{
				return true;
			}
			else
			{
				Console.WriteLine("Impossible move for this piece");
				return false;
			}
		}
		
		// Est-ce que la piece peut se deplacer vers endPos ?
		public abstract bool canMove(Position endPos, Piece[] pieces);

		public bool getIsBlack()
		{
			return isBlack;
		}
		public Position getPos()
		{
			return position;
		}
        public PictureBox getPicture()
        {
            return this.picture;
        }
    }
}
