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
        private double value;
		
		public Move(Position position, double value)
		{
			this.position = position;
			this.value = value;
		}

		public Position getPosition()
		{
			return position;
		}
		public double getValue()
		{
			return value;
		}
        public double setValue(double value)
        {
            this.value = value;
            return this.value;
        }
    }
}
