using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_07_bonus
	{
	class Program
		{
		static void Main(string[] args)
			{
			string input = "345";
			int inputNr;
			char[] arr = new char[input.Length];
			arr = input.ToCharArray();
			int[] numbers = new int[input.Length];
			string[] firstCifre = new string[] { "en", "to", "tre", "fire", "fem", "seks", "syv", "otte", "ni" };
			string[] ellevenToNineteen = new string[] { "elleve", "tolv", "tretten", "fjorten", "femten", "seksten", "sytten", "atten", "nitten" };
			string[] tens = new string[] { "ti", "tyve", "tredive", "fyrre", "halvtreds", "halvfjers", "halvfems" };
			string[] hundreds = new string[] { "ethundrede", "tohundrede", "trehundrede", "firehundrede", "femhundrede", "sekshundrede", "syvhundrede", "ottehundrede", "nihundrede" };

			for (int i = 0; i < arr.Length; i++)
				{
				inputNr = (int)Char.GetNumericValue(arr[i]);
				numbers[i] = inputNr;
				}




			switch (numbers.Length)
				{
				case 1:
					if(numbers[0] == 0)
						{
						Console.WriteLine("Nul");
						}
					else
						{
						Console.WriteLine(firstCifre[numbers[0] - 1]);
						}
					
					break;
				case 2:
					if (numbers[0] == 1 && numbers[1] > 0)
						{
						Console.WriteLine(ellevenToNineteen[numbers[1] - 1]);
						}
					else
						{
						if (numbers[1] == 0)
							{
							Console.WriteLine(tens[numbers[0] - 1]);
							}
						else
							{
							Console.WriteLine(firstCifre[numbers[1] - 1] + " og " + tens[numbers[0] - 1]);
							}
						}
					break;
				case 3:
					if (numbers[1] == 0 && numbers[2] == 0)
						{
						Console.WriteLine(hundreds[numbers[0] - 1]);
						}
					else if (numbers[1] == 1 && numbers[2] > 0)
						{
						Console.WriteLine(hundreds[numbers[0] - 1] + " og " + ellevenToNineteen[numbers[1] - 1]);
						}
					else if (numbers[1] == 0 && numbers[2] > 0)
						{
						Console.WriteLine(hundreds[numbers[0] - 1] + " og " + firstCifre[numbers[2] - 1]);
						}
					else
						{
						Console.WriteLine(hundreds[numbers[0] - 1] + " og " + firstCifre[numbers[2] - 1] + " og " + tens[numbers[1] - 1]);
						}

					break;
				case 4:
					if (numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0)
						{
						Console.WriteLine("ettusind");
						}
					else if (numbers[2] == 1 && numbers[3] > 0 || numbers[1] > 0 && numbers[2] == 1 && numbers[3] > 0)
						{
						if(numbers[1] > 0)
							{
							Console.WriteLine("ettusinde " + hundreds[numbers[1]-1] + " og " + ellevenToNineteen[numbers[1] - 1]);
							}
						else
							{
							Console.WriteLine("ettusinde og " + ellevenToNineteen[numbers[1] - 1]);
							}
						}
					else if (numbers[1] == 0 && numbers[2] > 0 && numbers[3] > 0)
						{
						Console.WriteLine("ettusind " + hundreds[numbers[0] - 1] + " og " + firstCifre[numbers[2] - 1] + " og " + tens[numbers[1] - 1]);
						}
					break;
					
				}

			Console.ReadLine();
			}
		}
	}
