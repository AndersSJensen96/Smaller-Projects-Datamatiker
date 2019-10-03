using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
	{
	class CasinoPlayer
		{
		private string name;
		private int chips;
		private int bet;
		private List<string> hand = new List<string> { };
		private int handSum = 0;
		private string win = "Draw";

		//<Properties>
		//Name get set
		public string Name 
			{
			get { return name; }
			set { name = value; }
			}
		//Chips get set
		public int Chips {
			get { return chips; }
			set {
				if (value >= 0)
					{
					chips = value;
					}
				}
			}
		//Bet get set
		public int Bet 
			{
			get { return bet; }
			set {
				if (value >= 0)
					{
					bet += value;
					Chips = Chips - value;
					}
				}
			}
		//Hand get set
		public List<string> Hand {
			get { return hand; }
			set {
				try
					{
					foreach (var card in value)
						{
						hand.Add(card);
						}
					}
				catch(Exception e)
					{
					Console.WriteLine(e);
					}
				
				}
			}
		// HandSum get set
		public int HandSum {
			get { return handSum; }
			set {
				if(value >= 0)
					{
						handSum = value;
					}
				}
			}
		//win check
		public string Win {
			get { return win; }
			set 
				{
				switch (value)
					{
					case "Win":
					case "Lost":
						win = value;
						break;
					}
				}
			}
		//</Properties>


		}
	}
