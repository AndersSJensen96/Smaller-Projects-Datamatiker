using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
    {
    class gameRun
        {
        private bool run = true;
        private string p1Input;
        private int p1;
        private string p1Mark;
        private int score1 = 0;
        private string p2Input;
        private int p2;
        private string p2Mark;
        private int score2= 0;
        private string contString;
        private string inTheLead;
        public void game()
            {
			while (run)
				{

				Console.Write("player 1 please choose 1. Rock, 2. Paper or 3. Scissors: ");
				p1Input = Console.ReadLine();

				Console.Write("player 2 please choose 1.Rock, 2.Paper or 3.Scissors: ");
				p2Input = Console.ReadLine();
				
                int.TryParse(p1Input, out p1);
                int.TryParse(p2Input, out p2);
                p1Mark = mark(p1);
                p2Mark = mark(p1);
                if (p1 == 1 && p2 == 3 || p1 == 2 && p2 == 1 || p1 == 3 && p2 == 2)
                    {
                    Console.WriteLine($"player 1 chose {p1Mark} and player 2 chose {p2Mark}\nplayer 1 won!");
                    score1++;
                    }
                else if (p2 == 1 && p1 == 3 || p2 == 3 && p1 == 2 || p2 == 2 && p1 == 1)
                    {
                    Console.WriteLine($"player 2 chose {p2Mark} and player 1 chose {p1Mark}\nplayer 2 won!");
                    score2++;
                    }
                if(score1 > score2 || score1 < score2)
                    {
                    inTheLead = score1 > score2 ? "Player 1 is in the lead" : "Player 2 is in the lead";
                    }
                else
                    {
                    inTheLead = "It's a draw";
                    }
                Console.WriteLine($"player 1 has {score1} points & Player 2 has {score2} points\n{inTheLead}");

                Console.Write("Type continue to play: ");
                contString = Console.ReadLine();
                run = contString == "continue" ? true : false;

                Console.ReadLine();
                }
            }

        private static string mark(int pMark)
            {
            switch (pMark)
                {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissor";
                default:
                    return "Error";
                }
            }
        private void winCondition()
            {

            }
        }
    }
