using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Game
    {
        public char[,] choices = new char[3, 3];
        public Player p1, p2;


        public Game()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    choices[i, j] = ' ';
                }
            }
             p1 = new Player();
             p2 = new Player();
        }

        public void addChoice(char choice,int row,int column)
        {
            this.choices[row,column] = choice;  

        }

        public bool isGameEnded()
        {
            if (this.choices.Length == 9)
                return true;
            else return false;
        }

        public Player winner()
        {

            //checking rows
            int i = 0, player1 = 0, player2 = 0;
            while (i < 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (choices[i, j] == p1.Choice)
                        player1++;
                    if (choices[i, j] == p2.Choice)
                        player2++;
                }
                if (player1 == 3)
                    return p1;
                else if (player2 == 3)
                    return p2;

                ++i;
                player1 = 0; player2 = 0;
            }

            //checking columns
            i = 0; player1 = 0; player2 = 0;
            while (i < 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (choices[j, i] == p1.Choice)
                        player1++;
                    if (choices[j, i] == p2.Choice)
                        player2++;
                }
                if (player1 == 3)
                    return p1;
                else if (player2 == 3)
                    return p2;

                ++i;
                player1 = 0; player2 = 0;
            }

            //checking diagonals
            if (choices[0, 0] == p1.Choice && choices[1, 1] == p1.Choice && choices[2, 2] == p1.Choice)
                return p1;
            if (choices[0, 0] == p2.Choice && choices[1, 1] == p2.Choice && choices[2, 2] == p2.Choice)
                return p2;

           if (choices[0, 2] == p1.Choice && choices[1, 1] == p1.Choice && choices[2, 0] == p1.Choice)
                return p1;
            if (choices[0, 2] == p2.Choice && choices[1, 1] == p2.Choice && choices[2, 0] == p2.Choice)
                return p2;

                return null;


        }
    }
}
