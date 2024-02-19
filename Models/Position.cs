using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Position
    {
        private int row;
        private int column;
        public int Row { get => row; }
        public int Column { get => column; }
        public Position(string position)
        {
            if (!ValidatePosition(position))
            {
                throw new Exception("Invalid position, select a free position between a1-c3");
            }
            string[] pos = position.Split("");
            row = char.Parse(pos[0]) - 'a';
            column = int.Parse(pos[1]) - 1;
        }
        public static bool ValidatePosition(string position)
        {
            // return true;
            string[] p = position.Split("");
            if (p.Length == 2)
            {
                char row = char.Parse(p[0]);
                char col = char.Parse(p[1]);
                if (row >= 'a' && row <= 'c'
                    && col >= '1' && col <= '3')
                {
                    return true;
                }
            }
            return false;
        }
    }
}