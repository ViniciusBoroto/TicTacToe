using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Match
    {
        private Board _board;
        public Board GameBoard { get => _board; }
        public Match(Board board)
        {
            _board = board;
        }
        public void MakeMove(Position position, string player)
        {
            //Verifica se a posição está vazia
            if (GameBoard.GetBoard()[position.Row, position.Column] != " ")
            {
                throw new Exception("This space has already been selected, choose a free one");
            }
            GameBoard.MakeMove(position, player);
        }
    }
}