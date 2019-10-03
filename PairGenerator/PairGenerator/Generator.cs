using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairGenerator
	{
	class Generator : TeamList
		{
		private List<string> workBuddies = new List<string> { };
		private List<string> pairList = new List<string> { };
		private Random rnd = new Random();
		private int rand;
		private int pairSize = 3;

		public int PairSize {
			get { return pairSize; }
			set 
				{
				if(value >= 2)
					{
					pairSize = value;
					}
				else
					{
					Console.WriteLine("size of each group is too small.\nMake it at least 2");
					}
				}
			}
		public List<string> PairList 
			{
			get { return pairList; }
			}

		public List<string> Generate()
			{
			ListReset();
			pairList.Clear();
			if (TList.Count >= 2)
				{
				int countPerGroup = TList.Count % PairSize;
				while (TList.Count > 0)
					{
					if (TList.Count > countPerGroup)
						{
						for (int i = 0; i < (TList.Count() / PairSize); i++)
							{
							for (int y = 0; y < PairSize; y++)
								{
								rand = rnd.Next(0, TList.Count());
								workBuddies.Add(TList[rand]);
								TList.RemoveAt(rand);
								}
							pairList.Add(String.Join(", ", workBuddies.ToArray()));
							workBuddies.Clear();
							}
						}
					else
						{
						foreach (var member in TList)
							{
							workBuddies.Add(member);
							}
						pairList.Add(String.Join(", ", workBuddies.ToArray()));
						workBuddies.Clear();
						TList.Clear();
						}
					}
				}
			else
				{
				Console.WriteLine("A minimum of 2 members are needed to create a pair\n missing {0}", (2 - TList.Count()));
				}

			return PairList;
			}
		}
	}
