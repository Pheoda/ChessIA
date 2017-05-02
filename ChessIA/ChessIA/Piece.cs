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

		public Piece(Position position, bool black, String pathImage, TableLayoutPanel parentPanel)
		{
			this.position = position;
			this.isBlack = black;
			this.picture = new PictureBox();
			FileStream fs = new FileStream(pathImage, FileMode.Open);
			picture.Image = Image.FromStream(fs);
			picture.Parent = parentPanel;
			fs.Close();
			refreshPicture();
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
		public void refreshPicture()
		{
			this.picture.Location = new Point(position.getX() * (picture.Parent.Size.Height / 8) + picture.Parent.Left, position.getY() * (picture.Parent.Size.Width / 8) + picture.Parent.Top);
			Console.WriteLine("IMAGE POSITION : " + (position.getX() * (picture.Parent.Size.Height / 8) + picture.Parent.Left) + "/" + (position.getY() * (picture.Parent.Size.Width / 8) + picture.Parent.Top));
		}
    }
}
