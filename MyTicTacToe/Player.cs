using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTicTacToe
{
    internal class Player
    {
        bool myTurn;
        bool isPlayer1;

        public Player(int i)
        {
            if(i == 1)
            {
                isPlayer1= true;
                myTurn = true;
            }
            if(i == 2)
            {
                isPlayer1= false;
                myTurn = false;
            }
        }

        public void setTurn(bool isMyTurn)
        {
            myTurn = isMyTurn;
        }
        public bool getTurn()
        {
            return myTurn;
        }

        public bool getPlayerNumber()
        {
            return isPlayer1;
        }
    }
}
