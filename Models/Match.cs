using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Match
    {
        private Board _board;
        private string _player;
        public Board GameBoard { get => _board; }
        public string player { get => _player; }
        public Match(Board board)
        {
            _board = board;
            _player = "X";
        }
        /// <summary>
        /// Verify if the position is free, makes the move and change the current player
        /// </summary>
        /// <param name="position"></param>
        /// <exception cref="Exception"></exception>
        public void MakeMove(Position position)
        {
            //Verifica se a posição está vazia
            if (GameBoard.GetBoard()[position.Row, position.Column] != " ")
            {
                throw new Exception("This space has already been selected, choose a free one");
            }
            GameBoard.MakeMove(position, player);
            _player = _player == "X" ? "Y" : "X";
        }
    }
}