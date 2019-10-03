using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
	{
	class NewDeck : CasinoPlayer
		{
		private string[] suit = new string[4] { "Heart", "Diamond", "Clover", "Spade" }; //for empty constructor to create default deck
		private List<string> deck = new List<string> { }; //deck that can hold default and custom deck in string form
		private List<string> playedCards = new List<string> { }; //List of cards that have been played
		private Random rand = new Random(); //Random Object for shuffle

		//Constructor for normal deck
		public NewDeck()
			{
			foreach (var suit in suit)
				{
				for (int i = 1; i <= 13; i++)
					{
					switch (i)
						{
						case 1:
							deck.Add($"Ace of {suit}s");
							break;
						case 11:
							deck.Add($"Jack of {suit}s");
							break;
						case 12:
							deck.Add($"Queen of {suit}s");
							break;
						case 13:
							deck.Add($"King of {suit}s");
							break;
						default:
							deck.Add($"{i} of {suit}");
							break;
						}
					}
				}
			}

		//Custom Deck Constructor
		public NewDeck(List<string> customDeck)
			{
			try
				{
				deck = customDeck.ToList();
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}
			}

		//<Properties>
		//Get deck
		public List<string> Deck {
			get { return deck; }
			}
		//Get playedCards
		public List<string> PlayedCards {
			get { return playedCards; }
			}
		//</Properties>


		//<Methods>
		//Draw Method
		public string DrawCard()
			{
			string drawnCards = null;
			try
				{
				drawnCards = Deck[0];
				playedCards.Add(Deck[0]);
				deck.Remove(Deck[0]);
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}

			return drawnCards;
			}
		public List<string> DrawCard(int amount)
			{
			List<string> drawnCards = new List<string> { };
			try
				{
				for (int i = 0; i < amount; i++)
					{
					drawnCards.Add(Deck[0]);
					playedCards.Add(Deck[0]);
					deck.Remove(Deck[0]);
					}
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}
			return drawnCards;
			}

		//ResetDeck
		public void ResetDeck()
			{
			try
				{
				foreach (var card in playedCards)
					{
					deck.Add(card);
					}
				playedCards.Clear();
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}

			}

		//Shuffle
		public void ShuffleDeck()
			{
			try
				{
				List<string> copyContainer = Deck.ToList();
				int length = copyContainer.Count();
				deck.Clear();
				for (int i = 0; i < length; i++)
					{
					int rndIndex = rand.Next(0, copyContainer.Count);
					deck.Add(copyContainer[rndIndex]);
					copyContainer.RemoveAt(rndIndex);
					}
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}
			}

		//PutBack
		public void ReturnCards(string card)
			{
			try
				{

				if (playedCards.Contains(card))
					{
					playedCards.Remove(card);
					deck.Add(card);
					}
				else
					{
					Console.WriteLine("The card haven't been played and therefor can't be returned");
					}
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}
			}
		public void ReturnCards(List<string> returnCards)
			{
			try
				{
				foreach (var card in returnCards)
					{
					if (playedCards.Contains(card))
						{
						playedCards.Remove(card);
						deck.Add(card);
						}
					else
						{
						Console.WriteLine("One or more of the cards haven't been played before and therefore can't be put back");
						}
					}
				}
			catch (Exception error)
				{
				Console.WriteLine(error);
				}
			}
		//</Methods>
		}
	}
