using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class IA
    {
        public IA ()
        {
        }

        public void play(List<Piece> pieces, int depth)
        {
            foreach (Piece piece in pieces)
            {
                if (piece.getIsBlack())
                {
                    foreach (Move node in piece.getPossibleMoves())
                    {
                        double value = minMax(node, piece, pieces, depth);
                    }
                }
            }
        }
        public double minMax(Move node, Piece piece, List<Piece> pieces, int depth)
        {
            Position oldPos = piece.getPos();
            piece.setPos(node.getPosition());

            if (depth == 0) //or Last node
            {
                piece.setPos(oldPos);
                return node.getValue();
            }

            if (piece.getIsBlack())
            {
                double bestValue = -10000;

                foreach (Piece pieceOppo in pieces)
                {
                    if (!pieceOppo.getIsBlack())
                    {
                        foreach (Move nodeChild in piece.getPossibleMoves())
                        {
                            double value = minMax(nodeChild, pieceOppo, pieces, depth - 1);
                            bestValue = max(bestValue, value);
                        }
                    }
                }
               
                return bestValue;
            }
            else
            {
                double bestValue = 10000;
                foreach (Piece pieceOppo in pieces)
                {
                    if (!pieceOppo.getIsBlack())
                    {
                        foreach (Move nodeChild in piece.getPossibleMoves())
                        {
                            double value = minMax(nodeChild, pieceOppo, pieces, depth - 1);
                            bestValue = min(bestValue, value);
                        }
                    }
                }
            }
            return 0;
        }

        private double min(double bestValue, double value)
        {
            return bestValue < value ? bestValue : value;
        }

        private double max(double bestValue, double value)
        {
            return bestValue > value ? bestValue : value;
        }
    }
}
