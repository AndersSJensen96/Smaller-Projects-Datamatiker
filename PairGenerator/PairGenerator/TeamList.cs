using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairGenerator
	{
	class TeamList
		{
		private List<string> tList = new List<string>
			{
			"Anders",
			"Christan",
			"Rasmus B",
			"Rasmus C",
			"Tobias",
			"Alexander",
			"Danny",
			"Nicolai"
			};
		// Properties
		public List<string> TList 
			{
			get { return tList; }
			}

		// <Methods>
		public void Add(string userInput)
			{
			tList.Add(userInput);
			}
		public void Delete(int index)
			{
			tList.RemoveAt(index);
			}
		public void ListReset()
			{
			tList = new List<string>
			{
			"Anders",
			"Christan",
			"Rasmus B",
			"Rasmus C",
			"Tobias",
			"Alexander",
			"Danny",
			"Nicolai"
			};
			}
		// </Methods>
		}
	}
