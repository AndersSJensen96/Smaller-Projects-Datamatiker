using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
	{
	class Program
		{
		static void Main(string[] args)
			{

			var gameDeck = new NewDeck();

			string[] players = new string[] { "Anders" };
			var game = new BlackJack(players);
			bool gameRun = true;

			while (gameRun)
				{
				if (gameDeck.Deck.Count == 0)
					{
					gameDeck.ResetDeck();
					}
				gameDeck.ShuffleDeck();
				game.Dealer(gameDeck.DrawCard(2));
				
				foreach (var player in game.PlayerList)
					{
					string userInput;
					int playerBet;
					bool input = false;
					bool hitOrStand = true;
					while (!input)
						{
						Console.WriteLine("player {0} currently has {1} Chips", player.Name, player.Chips);
						Console.Write("place a bet: ");
						userInput = Console.ReadLine();
						try
							{
							int.TryParse(userInput, out playerBet);
							player.Bet = playerBet;
							input = true;
							Console.Clear();
							}
						catch
							{
							Console.WriteLine("not a valid number");
							}
						}
					Console.WriteLine("Player {0} has {1} chips and made a bet of {2} chips", player.Name, player.Chips, player.Bet);
					player.Hand = gameDeck.DrawCard(2);

					while (hitOrStand)
						{
						player.HandSum = game.CheckCards(player.Hand, false);
						Console.WriteLine("{0} cards are : ", player.Name);
						foreach (string card in player.Hand)
							{
							Console.WriteLine("	{0} ", card);
							}
						Console.WriteLine("with a sum of {0}", player.HandSum);
						Console.WriteLine("Dealer has :");
						foreach (string card in game.DealerCards)
							{
							Console.WriteLine("{0}", card); //Hide First
							}
						Console.WriteLine("with a sum of {0}", game.DealerHandSum);
						player.HandSum = game.CheckCards(player.Hand, false);
						if (player.HandSum < 21)
							{
							Console.Write("Hit or stand?: ");
							userInput = Console.ReadLine();
							switch (userInput)
								{
								case "hit":
									player.Hand.Add(gameDeck.DrawCard());
									break;
								case "stand":
									hitOrStand = false;
									break;
								case "double":
									player.Bet = player.Bet * 2;
									player.Hand.Add(gameDeck.DrawCard());
									hitOrStand = false;
									break;
								}
							Console.Clear();
							}
						else
							{
							hitOrStand = false;
							}
						}
					}
				game.DealerTurn();
				game.WinCondition();
				}


			Console.ReadLine();
			}
		}
	}
