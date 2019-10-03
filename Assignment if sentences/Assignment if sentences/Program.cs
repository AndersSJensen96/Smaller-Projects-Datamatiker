using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_if_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
          
               /* int alderParse;
                Console.Write("Skriv dit navn ");
                string navn = Console.ReadLine();
                Console.Write("min alder: ");
                string alder = Console.ReadLine();
                int.TryParse(alder, out alderParse);
                
                if (alderParse >= 0 && alderParse <= 12)
                {
                    string message = "et barn";
                    Console.WriteLine(navn + " er " + alderParse + " gammel. Han er " + message);
                }else if (alderParse >= 13 && alderParse <= 19)
                    {
                    string message = "en teenager";
                    Console.WriteLine(navn + " er " + alderParse + " gammel. Han er " + message);
                    }
                else if (alderParse >= 20 && alderParse <= 25)
                    {
                    string message = "en studerende";
                    Console.WriteLine(navn + " er " + alderParse + " gammel. Han er " + message);
                    }
                else if (alderParse >= 26 && alderParse <= 67)
                    {
                    string message = "i arbejde";
                    Console.WriteLine(navn + " er " + alderParse + " gammel. Han er " + message);
                    }
                else if (alderParse > 67)
                    {
                    string message = "en pensionist";
                    Console.WriteLine(navn + " er " + alderParse + " gammel. Han er " + message);
                    }*/ 
                //Console.ReadLine();
            string menuPunkt;
            int parsedMenuPunkt;
            Console.WriteLine("Min fantastiske menu");

            Console.WriteLine("1. Gør dette \n2. Gør hint\n3. Gør noget\n4.Få svaret på livet, universet og alting\n");
            
            Console.Write("(Tryk menupunkt 1, 2, 3 eller 4) ");

            menuPunkt = Console.ReadLine();
            int.TryParse(menuPunkt, out parsedMenuPunkt);

            if(parsedMenuPunkt == 1){
                Console.WriteLine("Punkt " + parsedMenuPunkt + " er valgt: Gør dette");
            }else{
                Console.WriteLine("forkert valg");
            }
            Console.ReadLine();
        }
    }
}
