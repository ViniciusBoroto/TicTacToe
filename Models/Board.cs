using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {
        private string[,] board = new string[3, 3];
        public Board()
        {
            ResetBoard();
        }

        public string[,] GetBoard()
        {
            return board;
        }
        public void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }
        }

        public void ShowBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\t{board[i, 0]}  |  {board[i, 1]}  |  {board[i, 2]}");
                if (i < 2)
                {
                    Console.WriteLine("\t---|-----|---");
                }
            }
        }
    }
}