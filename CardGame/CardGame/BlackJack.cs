using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
	{

	class BlackJack : NewDeck
		{
		private List<CasinoPlayer> playerList = new List<CasinoPlayer> { };
		private int dealerHandSum = 0;
		private List<string> dealerCards = new List<string> { };
		private string dealerWin = "Draw";

		//<Constructor>
		public BlackJack(string[] players)
			{


			for (int i = 0; i < players.Length; i++)
				{
				playerList.Add(new CasinoPlayer { Name = players[i], Chips = 10 });
				}
			}
		//</Constructor>

		//<Properties>
		public List<CasinoPlayer> PlayerList {
			get { return playerList; }
			}
		public List<string> DealerCards {
			get { return dealerCards; }
			}
		public int DealerHandSum 
			{
			get { return dealerHandSum; }
			set 
				{
				if (value >= 0)
					{
					dealerHandSum = value;
					}
				}
			}
		public string Dealerwin {
			get { return dealerWin; }
			}
		//</Properties>

		//<Methods>
		public int CheckCards(List<string> cards, bool dealer)
			{
			int SumOfCards = dealer ? DealerHandSum : HandSum;
			try
				{
				string playerHand = string.Join(" ", cards.ToArray());
				string[] arr = playerHand.Split(' ');
				foreach (var item in arr)
					{
					switch (item)
						{
						case "Ace":
							if (SumOfCards + 11 <= 21)
								{
								SumOfCards += 11;
								}
							else
								{
								SumOfCards += 1;
								}
							break;
						case "Jack":
						case "Queen":
						case "King":
							SumOfCards += 10;
							break;
						default:
							try
								{
								int numb;
								int.TryParse(item, out numb);
								SumOfCards += numb;
								}
							catch (Exception e)
								{
								Console.WriteLine(e);
								}
							break;
						}
					}
				}
			catch (Exception e)
				{
				Console.Write(e);
				SumOfCards = 0;
				}
			return SumOfCards;
			}
		//Dealer
		public void Dealer(List<string> drawnCards) //use at the beggining to get dealer to draw first 2 cards
			{
			dealerCards.Clear();
			dealerHandSum += CheckCards(drawnCards, true);
			dealerCards = drawnCards;
			}
		public void DealerTurn() //use when dealers turn comes up again in the end
			{
			foreach (var value in playerList)
				{
				if (DealerHandSum < value.HandSum && DealerHandSum < 21)
					{
					dealerCards.Add(DrawCard());
					dealerHandSum = CheckCards(DealerCards, true);
					}
				}
			}
		//WinCondition 
		public void WinCondition() //Last method to be called that checks player against dealer
			{
			foreach (var player in playerList)
				{
				player.HandSum = CheckCards(player.Hand, false);
				int winnings = 0;
				if (player.HandSum <= 21)
					{
					if (player.HandSum > DealerHandSum || DealerHandSum > 21)
						{
						player.Win = "Win";
						winnings = (player.Bet * 2);
						player.Chips = player.Chips + winnings;
						}
					else if (player.HandSum < DealerHandSum)
						{
						dealerWin = "Win";
						player.Win = "Lost";
						}
					else
						{
						player.Chips = player.Chips + player.Bet;
						}
					}
				else
					{
					player.Win = "Lost";
					}
				Console.Write("Player {0} have a sum of {1} and the Dealer has a sum of {2} ", player.Name, player.HandSum, DealerHandSum);
				switch (player.Win)
					{
					case "Win":
						Console.WriteLine("you won");
						break;
					case "Lost":
						Console.WriteLine("you lost");
						break;
					case "Draw":
						Console.WriteLine("it's a draw");
						break;
					}
				if(player.Chips == 0)
					{
					Console.WriteLine("player {0} has no more chips and will be removed");
					Console.Write(playerList.IndexOf(new CasinoPlayer { Name = player.Name }));
					}
				}
			}
		//</Methods>


		}
	}
