using System;
using System.Collections.Generic;
namespace sandbox
    {
    class Program
        {
        static void Main(string[] args)
            {
			//string str;

			/*
                int parsedMenuPunkt;
                bool end = false;
            while (!end)
                {
                Console.WriteLine("Min fantastiske menu");

                Console.WriteLine("1. Gør dette \n2. Gør hint\n3. Gør noget\n4.Få svaret på livet, universet og alting\n");

                Console.Write("(Tryk menupunkt 1, 2, 3 eller 4 (9 to end)) ");
                string menuPunkt = Console.ReadLine();
                if(int.TryParse(menuPunkt, out parsedMenuPunkt))
                    {
                    switch (parsedMenuPunkt)
                        {
                        case 1:
                            Console.WriteLine("Punkt " + parsedMenuPunkt + " er valgt: Gør dette");
                            break;
                        case 2:
                            Console.WriteLine("Punkt " + parsedMenuPunkt + " er valgt: Gør hint");
                            break;
                        case 3:
                            Console.WriteLine("Punkt " + parsedMenuPunkt + " er valgt: Gør noget");
                            break;
                        case 4:
                            Console.WriteLine("Punkt " + parsedMenuPunkt + " er valgt: 42");
                            break;
                        case 9:
                            end = true;
                            break;
                        default:
                            Console.WriteLine("forkert valg");
                            break;
                        }
                    }
                else
                    {
                    Console.WriteLine("try again with a valid number");
                    }
               
                }*/


			//Console.WriteLine(str[3] + " " + str[5]);
			/*int nr = str.Length;
            int count = 0;
            do
                {
                Console.WriteLine(str[count]);
                count++;
                } while (count < nr);
                Console.ReadLine();*/

			/* Console.WriteLine("input math calculation: ");
             string math = Console.ReadLine();
             float calc= 0;
             string opera = "+";
             for(int i = 0; i < math.Length; i++)
                 {
                 char mathCh = math[i];
                 if (Char.IsDigit(mathCh))
                     {
                     float.TryParse(mathCh.ToString(), out float number);
                     if(opera == "+")
                         {
                         calc += number;
                         }else if(opera == "-")
                         {
                         calc -= number;
                         }
                     else if (opera == "*")
                         {
                         calc *= number;
                         }
                     else if (opera == "/")
                         {
                         calc /= number;
                         }
                     }
                 else
                     {
                     string tostr = Char.ToString(mathCh);
                     switch (tostr)
                         {
                         case "+":
                             opera = "+";
                             break;

                         case "-":
                             opera = "-";
                             break;
                         case "*":
                             opera = "*";
                             break;
                         case "/":
                             opera = "/";
                             break;
                         default:
                             Console.WriteLine(i + ": " + tostr + " {0}", opera);
                             break;

                         }
                     }

                 }
                 */
			Console.WriteLine("write something biiitch");
			string choose = null;
			if(Console.ReadKey().Key == ConsoleKey.D1)
				{
				choose = "Sten";
				Console.Clear();
				}
			else if(Console.ReadKey().Key == ConsoleKey.D2)
				{
				choose = "saks";
				Console.Clear();
				}
			else if(Console.ReadKey().Key == ConsoleKey.D2)
				{
				choose = "papir";
				Console.Clear();
				}
			//Console.ReadKey(true);
			Console.Write(choose);
			Console.ReadLine();
            }
        }
    }
