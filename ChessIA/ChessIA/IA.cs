using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessIA
{
    class AI
    {
        private Piece piece;
        private Move node;
        public Piece Piece 
        {
            get
            {
                return this.piece;
            }
        }
        public Move Node 
        {
            get
            {
                return this.node;
            }
        }
        public void play(List<Piece> pieces, int depth)
        {
            double max = -10000;

            foreach (Piece p in pieces)
            {
                if (p.getIsBlack())
                {
                    foreach (Move node in p.getPossibleMoves())
                    {
                        double value = minMax(node, p, pieces, depth, true) - node.getValue();
                        Console.WriteLine("Value : " + value);
                        if (value >= max)
                        {
                            max = value;
                            this.node = node;
                            this.piece = p;
                        }
                        Console.WriteLine("fin max" + max);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("IA");
            Console.WriteLine("Nombre : " + pieces.Count);
            for (int i = 0; i < pieces.Count; i++)
                Console.WriteLine("Pos : " + pieces[i].getPos().getX() + "/" + pieces[i].getPos().getY());

        }
        public double minMax(Move node, Piece p, List<Piece> pieces, int depth, bool black)
        {
           // Piece oldPiece = p;
            //p.setPos(node.getPosition());


            if (depth == 0) //or Last node
            {
                return node.getValue();
            }

            if (black)
            {
                double bestValue = 10000;

                foreach (Piece pieceOppo in pieces)
                {
                    if (!pieceOppo.getIsBlack())
                    {
                        foreach (Move nodeChild in p.getPossibleMoves())
                        {
                           Position oldPosOppo = pieceOppo.getPos();
                           pieceOppo.setPos(nodeChild.getPosition());

                            double value = minMax(nodeChild, pieceOppo, pieces, depth - 1, false) + node.getValue();
                            bestValue = min(bestValue, value);
                            //Console.WriteLine("min : " + bestValue  + "tour" + depth);
                            //Console.WriteLine("white : " + oldPosOppo.getX() + ", " + oldPosOppo.getY());

                            pieceOppo.setPos(oldPosOppo);
                        }
                    }
                }
               
                return bestValue;
            }
            else
            {
                double bestValue = -10000;
                foreach (Piece pieceAI in pieces)
                {
                    if (pieceAI.getIsBlack())
                    {
                        foreach (Move nodeChild in p.getPossibleMoves())
                        {
                            Position oldPosAI = pieceAI.getPos();
                            pieceAI.setPos(nodeChild.getPosition());

                            double value = minMax(nodeChild, pieceAI, pieces, depth - 1, true) - node.getValue();
                            //Console.WriteLine("black : " + oldPosAI.getX() + ", " + oldPosAI.getY());
                            bestValue = max(bestValue, value);
                           // Console.WriteLine("max : " + bestValue + "tour" + depth);
                            pieceAI.setPos(oldPosAI);
                        }
                    }
                }
                return bestValue;
            }
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
