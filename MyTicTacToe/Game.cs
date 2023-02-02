using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MyTicTacToe
{
    internal class Game
    {
        Player[] players;
        Board board;
        enum gameState 
        { 
        Active,
        Player1Win,
        Player2Win,
        Stalemate
        }

        //We are in an active gameState, P1 has the 1st turn, board is initialised.
        public Game()
        {
            gameState currentGame = gameState.Active;
            players = new Player[2];

            Player P1 = new Player(1);
            Player P2 = new Player(2);
            players[0] = P1;
            players[1] = P2;
            board = new Board();
        }

        public bool checkWinCondition()
        {

            return false;
        }


    }
}
