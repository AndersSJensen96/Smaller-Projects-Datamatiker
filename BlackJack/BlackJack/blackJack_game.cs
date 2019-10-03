using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
	{

	class blackJackGame
		{
		//<Variables, arrays, lists definition>
		//Deck arrays 
		private string[] cardSuit = new string[] { "Heart", "Spade", "Diamond", "Clover" };
		private string[] pictureCard = new string[] { "Jack", "Queen", "King" };

		//players and hand value
		private int playersAmount = 1;
		private int playerTurn = 1;
		private Dictionary<string, int> playerList = new Dictionary<string, int> { };
		private Dictionary<string, string> playerMessage = new Dictionary<string, string> { };
		private List<string> playedCards = new List<string> { };
		private int playerHand = 0;


		//variables unique to cardDraw()

		private Random rand = new Random(); //new random used in cardDraw for suit and card value
		private string draw;

		//</Variables, arrays, lists definition>



		//<Constructor>
		public blackJackGame()
			{
			playersAmount = 1;
			playerList.Add($"Player1", playerHand);
			playerList.Add("Dealer", playerHand);
			}
		public blackJackGame(int players)
			{
			playersAmount = players;
			//players
			for (int i = 1; i <= players; i++)
				{
				playerList.Add($"Player{i}", playerHand);
				}
			playerList.Add("Dealer", playerHand);
			}
		//</Constructor>

		//<Properties>

		//</Properties>


		//<Methods>
		//Reset value of current Hand
		public void playersHandReset()
			{
			playerHand = 0;
			}
		//next Player
		public void playerTurnIncrement()
			{
			playerTurn++;
			}
		//Show current players hand (value)
		public int playersHand()
			{
			return playerHand;
			}
		//Show the current player (turn)(dealer is 0)
		public int currentPlayer()
			{
			int player = playerTurn <= playersAmount ? playerTurn : 0;
			return player;
			}
		//Show the amount of players in the game (not counting dealer)
		public int playerAmount()
			{
			return playersAmount;
			}

		//carddraw
		public void cardDraw()
			{
			bool validCard = false;
			while (!validCard)
				{
				int randNumb = rand.Next(1, 10);
				int randSuit = rand.Next(0, cardSuit.Length);


				if (randNumb == 1)
					{
					randNumb = (11 + playerHand) > 21 ? 1 : 11;
					}
				switch (randNumb)
					{
					case 1:
						draw = "Ace of " + cardSuit[randSuit];
						break;
					case 11:
						draw = "Ace of " + cardSuit[randSuit];
						break;
					case 10:
						int randPic = rand.Next(0, pictureCard.Length);
						draw = randPic + " of " + cardSuit[randSuit];
						break;
					default:
						draw = randNumb + " of " + cardSuit[randSuit];
						break;
					}
				if (!playedCards.Contains(draw))
					{
					validCard = true;
					playedCards.Add(draw);
					playerHand += randNumb;
					string thePlayer = currentPlayer() == 0 ? "Dealer" : "Player" + currentPlayer();
					
					playerList[thePlayer] = playerHand;
					}
				}

			}//End carDraw()

		//Dealer "AI"
		public void dealerAI()
			{
			bool dealerOn = true;
			int i = 1;
			while (dealerOn)
				{
				if(i == playersAmount)
					{
						i = 1;
					}
				int dealer = playerList["Dealer"];
					if(dealer > playerList[$"Player{i}"])
					{
					dealerOn = false;
					}
				else
					{
					cardDraw();
					}
				i++;
				}

			}

		//Final Score
		public void finalScore()
			{
			Console.WriteLine($"The Dealer has {playerList["Dealer"]}");
			for (int i = 1; i < playersAmount; i++)
				{
				string thePlayer = "Player" + i;
				if (playerList[thePlayer] < playerList["Dealer"] && playerMessage[thePlayer] == "hold")
					{
						Console.WriteLine($"{thePlayer} has a totalt of {playerList[thePlayer]} and has therefore lost to the dealer");
					}
				}
			}


		//</Methods>

		} //End Class blackJack_game
	} //End NameSpace BlackJack
