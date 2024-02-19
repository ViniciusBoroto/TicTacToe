using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// Verify if the position is free, makes the move and change the current player.
        /// </summary>
        /// <param name="position"></param>
        /// <exception cref="Exception"></exception>
        public bool MakeMove(Position position)
        {
            //Verifica se a posição está vazia
            if (GameBoard.GetBoard()[position.Row, position.Column] != " ")
            {
                throw new Exception("This space has already been selected, choose a free one");
            }
            GameBoard.MakeMove(position, player);
            _player = _player == "X" ? "Y" : "X";
            return true;
        }
        public string? CheckWinner()
        {
            string currentPos;
            int xCount;
            int yCount;
            //Lines
            for (int i = 0; i < 3; i++)
            {
                //Verificando a linha
                xCount = 0;
                yCount = 0;
                for (int j = 0; j < 3; j++)
                {
                    //Verificando cada elemento da linha
                    currentPos = GameBoard.GetBoard()[i, j];
                    if (currentPos == " ") { break; }
                    if (currentPos == "X")
                    {
                        xCount++;
                    }
                    else
                    {
                        yCount++;
                    }
                }
                if (xCount == 3)
                {
                    return "X";
                }
                else if (yCount == 3)
                {
                    return "Y";
                }
            }
            //columns
            for (int j = 0; j < 3; j++)
            {
                //Verificando a coluna
                xCount = 0;
                yCount = 0;
                for (int i = 0; i < 3; i++)
                {
                    //Verificando cada elemento da coluna
                    currentPos = GameBoard.GetBoard()[i, j];
                    if (currentPos == " ") { break; }
                    if (currentPos == "X")
                    {
                        xCount++;
                    }
                    else
                    {
                        yCount++;
                    }
                }
                if (xCount == 3)
                {
                    return "X";
                }
                else if (yCount == 3)
                {
                    return "Y";
                }
            }

            //diagonal \
            xCount = 0;
            yCount = 0;
            for (int i = 0; i < 3; i++)
            {
                currentPos = GameBoard.GetBoard()[i, i];
                if (currentPos == " ") { break; }
                if (currentPos == "X")
                {
                    xCount++;
                }
                else
                {
                    yCount++;
                }
                if (xCount == 3)
                {
                    return "X";
                }
                else if (yCount == 3)
                {
                    return "Y";
                }
            }

            //diagonal /
            xCount = 0;
            yCount = 0;
            for (int i = 0; i < 3; i++)
            {

                currentPos = GameBoard.GetBoard()[i, 2 - i];
                if (currentPos == " ") { break; }
                if (currentPos == "X")
                {
                    xCount++;
                }
                else
                {
                    yCount++;
                }
            }
            if (xCount == 3)
            {
                return "X";
            }
            else if (yCount == 3)
            {
                return "Y";
            }


            return null;
        }
    }
}