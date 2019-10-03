using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string[,] arr = new string[3,3] {{" ", " ", " "},{"X", "X", "X"}, {" ", "X", " "}};
            int PatternCount;
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    if(arr[0, j] == "X"){
                        arr[0, j] = "Win";
                        Console.Write("test0");
                    }else if(arr[1, j] == "X"){
                        arr[1, j] = "Win";
                        Console.Write("test1");
                    }else if(arr[2, j] == "X"){
                        arr[2, j] = "Win";
                        Console.Write("test2");
                    }
                   Console.Write(arr[i, j]);
                }
               Console.WriteLine();
            }
            
           /* int pos = Array.IndexOf(arr[0], 2);
            Console.Write(pos);*/
            Console.ReadLine();
        }
    }
}
