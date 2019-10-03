using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairGenerator
	{
	class Program
		{
		static void Main(string[] args)
			{
			string userInput;
			int menuPoint = 0;
			int number;
			var generator = new Generator();
			var teamList = new TeamList();
			bool programRun = true;
			while (programRun)
				{
				bool enterValue = false;
				//USERINPUT
				Console.WriteLine("1. Generate Pairs");
				Console.WriteLine("2. Edit TeamList");
				Console.WriteLine("3. End program");
				Console.Write("Please choose by entering the number: ");
				userInput = Console.ReadLine();
				Console.Clear();
				if (int.TryParse(userInput, out menuPoint))
					{
					//GENERATE
					if (menuPoint == 1)
						{
						while (true)
							{
							Console.WriteLine("Back: Go back\n");
							Console.Write("Please enter the size of each group: ");
							userInput = Console.ReadLine();
							if (int.TryParse(userInput, out number))
								{
								generator.PairSize = number;
								generator.Generate();
								foreach (var pairs in generator.PairList)
									{
									Console.WriteLine(pairs);
									}
								break;
								}
							else if(userInput.ToUpper() == "BACK")
								{
								break;
								}
							else
								{
								Console.WriteLine("Not a valid Number");
								}
							}
						Console.ReadLine();
						}
					//EDIT TEAM
					else if (menuPoint == 2)
						{
						while (true)
							{
							Console.WriteLine("current members: ");
							foreach (var member in teamList.TList)
								{
								Console.WriteLine(member);
								}
							Console.WriteLine();
							Console.WriteLine("1. Add member");
							Console.WriteLine("2. Delete member");
							Console.WriteLine("3. Go Back to main menu");
							Console.Write("Please choose by entering the number ");
							userInput = Console.ReadLine();
							Console.Clear();
							if (int.TryParse(userInput, out menuPoint))
								{
								if(menuPoint == 1)
									{
									Console.WriteLine("Back: Go back\n");
									Console.Write("Enter name to add that person: ");
									userInput = Console.ReadLine();
									if (userInput.ToUpper() == "BACK")
										{
										break;
										}
									else
										{
										teamList.Add(userInput);
										}
									}
								else if(menuPoint == 2)
									{
									while (true)
										{
										Console.WriteLine("Back: Go back\n");
										for (int i = 0; i < teamList.TList.Count(); i++)
											{
											Console.WriteLine("{0}. {1}", (i + 1), teamList.TList[i]);
											}
										Console.Write("Please choose one to delete: ");
										userInput = Console.ReadLine();
										if (int.TryParse(userInput, out number))
											{
											if (number >= 0 && number <= teamList.TList.Count())
												{
												teamList.Delete(number - 1);
												break;
												}
											else
												{
												Console.WriteLine("Number not in specified range");
												}
											}
										else if (userInput.ToUpper() == "BACK")
											{
											break;
											}
										else
											{
											Console.WriteLine("Please enter valid number");
											}
										Console.ReadLine();
										Console.Clear();
										}
									}
								else if(menuPoint == 3)
									{
									break;
									}
								else
									{
									Console.WriteLine("Please enter valid number");
									}
									
								}
							else
								{
								Console.WriteLine("Input Choosen did not match the menu points");
								}
							Console.Clear();
							}
						}
					//END PROGRAM
					else if (menuPoint == 3)
						{
						programRun = false;
						}
					//WRONG MENU POINT
					else
						{
						Console.WriteLine("Input Choosen did not match the menu points");
						}
					}
				//INPUT WASN'T A NUMBER
				else
					{
					Console.WriteLine("Input was not a valid number");
					}
				Console.Clear();
				}//PROGRAMRUN WHILE --- END
			}//MAIN --- END
		}//PROGRAM --- END
	}//NAMESPACE --- END
