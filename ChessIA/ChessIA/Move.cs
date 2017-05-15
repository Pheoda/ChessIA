using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class Move
    {
        private Position position;
        private int value;
		
		public Move(Position position, int value)
		{
			this.position = position;
			this.value = value;
		}

		public Position getPosition()
		{
			return position;
		}
		public int getValue()
		{
			return value;
		}
    }
}
