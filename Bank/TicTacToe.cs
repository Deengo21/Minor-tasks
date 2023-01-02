using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNamespace
{
   public class TicTacToe
    {
        char[] fields = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

        public void Move(int space, char player)
        {
            fields[space] = player;
        }

        public char GetValue(int space)
        {
            return fields[space];
        }
        
        public char GetWinner()
        {
            //       0 1 2
            //       3 4 5
            //       6 7 8
            // && and
            // || or

            // Vertically
            if (fields[0] == fields[3] && fields[0] == fields[6])
                return fields[0];
            if (fields[1] == fields[4] && fields[1] == fields[7])
                return fields[1];
            if (fields[2] ==  fields[5]  && fields[2] == fields[8] )
                return fields[2];

            // Horizontally
            if (fields[0] == fields[1]  && fields[0] == fields[2])
                return fields[0];
            if (fields[3] == fields[4] && fields[3] == fields[5])
                return fields[3];
            if (fields[6] == fields[7] && fields[6] == fields[8])
                return fields[6];


            // Diagonally
            if (fields[0] == fields[4] && fields[0] == fields[8])
                return fields[4];
            if (fields[2] == fields[4] && fields[6] == fields[4])
                return fields[4];

            return '0';
        }

    }
}


// var game = new TicTacToe()
// game.Move(2, 'x')
// var winningPlayer = game.getWinner()
// winningPlayer == 'x' <- true/false