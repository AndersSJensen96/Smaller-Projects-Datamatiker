using System;

namespace TicTacToe
    {
    class Program
        {
        static void Main(string[] args)
            {
            string[,] board = new string[4, 4] { { "|", "|", "|", "|" }, { "|", "|", "|", "|" }, { "|", "|", "|", "|" }, { "|", "|", "|", "|" } };
            string[,] placement = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            string[] placementCoordinatesX = new string[3];
            string[] placementCoordinatesO = new string [3];

            bool gameEnd = false;
            bool pieceLimit = false;

            int countMarks = 0;
            bool playerTurn = true;
            string playerMark = "X";
            bool playerInput = false;

            string column;
            int columnParsed;
            string row;
            int rowParsed;

            string winCheck = "none";
            int winCheckRow = 0;
            int winCheckColumn = 0;

            while (!gameEnd)
                {
                 if(countMarks == 6){
                    pieceLimit = true;
                 }
                //user input into placement array
                while (!playerInput)
                    {
                        //Console.Write(placementCoordinates); 
                        Console.Write("Please choose a row: ");
                        row = Console.ReadLine();
                        Console.Write("Please choose a column: ");
                        column = Console.ReadLine();
                        if(pieceLimit){
                           if(playerTurn){
                                /*Console.WriteLine("piece limit reached\n please select a new placement for the first set piece.");
                                Console.Write("Enter row");
                                row = Console.ReadLine();
                                Console.Write("Enter column");
                                column = Console.ReadLine();
                                //string[] coordArr = placementCoordinatesX[0].Split(",");
                                //Console.Write(coordArr[0] + " " + coordArr[1]);
                                Console.Write(placementCoordinatesX[0]);
                                //placement[]*/
                                Console.Write("PieceLimit X");
                                
                            }else{
                                Console.Write("PieceLimit X");
                            }
                        }else{                  
                            if(playerTurn){
                                for(int i = 0; i < 3; i++){
                                    if(placementCoordinatesX[i] == null){
                                        string coord = row + "," + column;
                                        placementCoordinatesX[i] = coord;
                                        break;
                                    }
                                }
                            }else{
                                for(int i = 0; i < 3; i++){
                                   if(placementCoordinatesO[i] == null){
                                        string coord = row + "," + column;
                                        placementCoordinatesO[i] = coord;
                                        break;
                                    }
                                }
                            }
                        }
                    //Failsafe: check if input is an integer and if it's a right number within the range of the board
                    if (int.TryParse(row, out rowParsed) && int.TryParse(column, out columnParsed))
                        {
                            if(rowParsed < 0 ||rowParsed > 3 || columnParsed < 0 || columnParsed > 3){
                                Console.WriteLine("Number is not within the confines of the board\nplease choose again");
                                Console.ReadLine();
                            } 
                            else
                                {
                                    countMarks++;
                                    if (playerTurn)
                                        {
                                        playerMark = "X";
                                        }
                                    else
                                        {
                                        playerMark = "O";
                                        }
                                    playerInput = true;
                                    placement[(rowParsed - 1), (columnParsed - 1)] = playerMark;
                                }
                        }
                        else
                            {
                            Console.WriteLine("Error in choosing a number\nplease choose again");
                            Console.ReadKey();
                            }
                    }
                //Board and placement build
                for (int i = 0; i < 3; i++)
                    {
                    for (int x = 0; x < 4; x++)
                        {
                        if (x < 3)
                        {
                            //draw board + placement
                            Console.Write(board[i, x] + placement[i, x]);
                            //Winning condition Row - column - diagonal x2
                            if(placement[i, x] == playerMark && !gameEnd){
                                  winCheckRow++;
                                  gameEnd = winCheckRow == 3 ? true : false;
                                  if(gameEnd){
                                    winCheck = "row";
                                  }
                              }
                              if( placement[x, i] == playerMark && !gameEnd){
                                  winCheckColumn++;
                                  gameEnd = winCheckColumn == 3 ? true : false;
                                  if(gameEnd){
                                    winCheck = "column";
                                  }
                              }
                              if(placement[0, 0] == playerMark && placement[1,1] == playerMark && placement[2,2] == playerMark || placement[0,2] == playerMark && placement[1,1] == playerMark && placement[2,0] == playerMark){
                                gameEnd = true;
                                winCheck = "diagonal";
                              }
                              /*Check amount of playerMark & if it's 3 get the coordinates
                              if (placement[i, x] == playerMark)
                              {
                                  countMarks++;
                                  if(countMarks == 6){
                                     pieceLimit = true;
                                    Console.WriteLine(countMarks);
                                  }
                              }*/


                        }
                        else
                        {
                        //last ends of the board
                         Console.Write(board[i, x]);
                        }    
                            
                        }
                        //winCheck reset
                        winCheckColumn = 0;
                        winCheckRow = 0;
                    Console.Write(Environment.NewLine);
                    }
                    Console.ReadLine();
                    playerInput = false;
                    if (playerTurn)
                    {
                        playerTurn = false;
                    }
                    else
                    {
                        playerTurn = true;
                    }
                    if(gameEnd){
                        int player = !playerTurn ? 1 : 2;
                        Console.WriteLine("Congratz player " + player + " won with a " + winCheck);
                        Console.ReadKey();
                    }
                
                }
            }
        }
    }
/*int count = 0;
            string[,] placement = new string[3, 3] { { "X", " ", " " }, { " ", "X", " " }, { "X", " ", " " } };
            string[] placementCoordinates = new string[3];
            for (int i = 0; i < 3; i++)
                {
                for (int y = 0; y < 3; y++)
                    {
                    if (placement[i, y] == "X")
                        {
                        count++;
                        if (count <= 3)
                            {
                            var tupleTest = Tuple.Create(i, y);
                            string data = tupleTest.Item1 + "," + tupleTest.Item2;
                            placementCoordinates[i] = data;
                            //Console.Write("Aaay too many");
                            }
                        }
                    }
                }
                foreach(string value in placementCoordinates)
                    {
                    Console.WriteLine(value);
                    }
            Console.ReadKey();*/