using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
	class Position
	{
		int x;
		int y;

		public Position(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int getX()
		{
			return x;
		}
		public int getY()
		{
			return y;
		}

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (typeof(Position) != obj.GetType())
            {
                return false;                
            }
            Position pos = (Position)obj;
 
            return pos.getX() == this.getX() && pos.getY() == this.getY();
        }
	}
}
