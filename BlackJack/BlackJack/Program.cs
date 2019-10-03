using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
	{
	class Program
		{
		static void Main(string[] args)
			{
			var blackJack = new blackJackGame(2);

			bool firstDraw = false;
			bool gameRun = true;
			string EndMessage;//message at game end
			Dictionary<string, int> playerList = new Dictionary<string, int> { };
			for (int i = 1; i <= blackJack.playerAmount(); i++)
				{
				playerList.Add("player" + i, blackJack.playersHand());
				}
			playerList.Add("Dealer", blackJack.playersHand());
			while (gameRun)
				{
				Console.Clear();
				string currentPlayer = blackJack.currentPlayer() == 0 ? "Dealer" : $"player{ blackJack.currentPlayer()}";
				Console.WriteLine($"{currentPlayer} has a total of {playerList[currentPlayer]}");
				if (!firstDraw)
					{
					for (int i = 0; i < 2; i++)
						{
						blackJack.cardDraw();
						}
					firstDraw = true;
					}
				else if (blackJack.playersHand() >= 21)
					{
					EndMessage = blackJack.playersHand() == 21 ? "You won!" : "You Lost!";
					firstDraw = false;
					blackJack.playersHandReset();
					blackJack.playerTurnIncrement();
					}
				else if (currentPlayer == "Dealer")
					{

						blackJack.dealerAI();
						gameRun = false;
				

					}
				else
					{
					Console.Write("draw or hold? : ");
					string userInput = Console.ReadLine();
					switch (userInput)
						{
						case "draw":
							blackJack.cardDraw();
							break;
						default:
							blackJack.playersHandReset();
							firstDraw = false;
							blackJack.playerTurnIncrement();
							break;
						}
					}

				playerList[currentPlayer] = blackJack.playersHand();
				

				}//End gameRun()
			blackJack.finalScore();
			Console.WriteLine("Game done\n add score list");
			Console.ReadLine();
			}
		}
	}
