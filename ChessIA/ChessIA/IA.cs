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
            double bestValue = -10000;

            foreach (Piece p in pieces)
            {
                if (p.getIsBlack())
                {
                    foreach (Move node in p.getPossibleMoves())
                    {
                        double value = max(node, p, pieces, depth);
                      
                        if (value >= bestValue)
                        {
                            bestValue = value;
                            this.node = node;
                            this.piece = p;
                        }
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

        private double min(Move node, Piece p, List<Piece> pieces, int depth)
        {
            if (depth == 0)
            {
                return node.getValue();
            }
            double bestValue = 10000;

            foreach (Piece pieceOppo in pieces)
            {
                if (!pieceOppo.getIsBlack())
                {
                    foreach (Move nodeChild in p.getPossibleMoves())
                    {
                        Position oldPosOppo = pieceOppo.getPos();
                        pieceOppo.setPos(nodeChild.getPosition());
                        
                        double value = max(nodeChild, pieceOppo, pieces, depth - 1) + nodeChild.getValue();

                        if (value < bestValue)
                        {
                            bestValue = value;
                        }

                        pieceOppo.setPos(oldPosOppo);
                    }
                }
            }

            return bestValue;
            //return bestValue < value ? bestValue : value;
        }

        private double max(Move node, Piece p, List<Piece> pieces, int depth)
        {
            if (depth == 0)
            {
                return node.getValue();
            }

            double bestValue = -10000;

            foreach (Piece pieceAI in pieces)
            {
                if (pieceAI.getIsBlack())
                {
                    foreach (Move nodeChild in p.getPossibleMoves())
                    {
                        Position oldPosAI = pieceAI.getPos();
                        pieceAI.setPos(nodeChild.getPosition());

                        double value = min(nodeChild, pieceAI, pieces, depth - 1) + nodeChild.getValue();

                        if (value > bestValue)
                        {
                            bestValue = value;
                        }

                        pieceAI.setPos(oldPosAI);
                    }
                }
            }
            return bestValue;
            //return bestValue > value ? bestValue : value;
        }
    }
}
