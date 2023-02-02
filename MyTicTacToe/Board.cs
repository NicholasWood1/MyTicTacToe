using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTicTacToe
{
    internal class Board
    {
        Cell[,] cell;
        public Board() {
            cell = new Cell[3,3];
        }
    }
}
