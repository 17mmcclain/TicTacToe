using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TicTacToe
{
    public class TicTacToeFunctions
    {
        public int[,] board = new int[3, 3];

        public TicTacToeFunctions()
        {
            board = new int[3, 3]
            {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0},
            };
        }

        public void OutPutArray(int[,] array)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
            Console.WriteLine("   |   |   ");
        }

        public int WhoIsFirst()
        {
            Console.Write("Select player 1 or player 2 to go first (numbers only): ");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                int number = 1;
                return number;
            }
            else
            {
                int number = 2;
                return number;
            }
        }

        public void Rules()
        {
            Console.WriteLine("In case you haven't played Tic Tac Toe before, the rules are simple.\n" +
                "First you will decide if player 1 or player 2 will go first.\n" +
                "Once decided, the chosen player will pick a spot to put there player number in. Empty spots only.\n" +
                "Once a player has 3 spots in a row, they have won. Otherwise, it's a tie.\n" +
                "To pick a spot, each spot can be represented by counting from 1-9, left to right, and top to bottom.\n" +
                "7 - 8 - 9\n" +
                "4 - 5 - 6\n" +
                "1 - 2 - 3");
        }

        public void PlayFunction()
        {
            int selection = WhoIsFirst();
            if (selection == 1)
            {
                Player1functions();
                
            }
            if (selection == 2)
            {
                Player2Functions();
                
            }
        }

        public int CheckWhoWon()
        {
            //checking for player 1 wins first.

            //checking for horizontal wins

            if ((board[0,0] == 1 && board[0,1] == 1 && board[0,2] == 1) || (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1) || (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1))
            {
                return 1;
            }
            
            //checking for diagonal wins

            else if ((board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1) || (board[0,2] == 1 && board[1,1] == 1 && board[2, 0] == 1))
            {
                return 1;
            }

            //checking for vertical wins

            else if ((board[0, 0] == 1 && board[1, 0] == 1 && board[2,0] == 1) || (board[0, 1] == 1 && board[1, 1] == 1 && board[2,1] == 1) || (board[0,2] == 1 && board[1,2] == 1 && board[2, 2] == 1))
            {
                return 1;
            }

            //checking for player 2 wins now.

            //checking for horizontal wins

            if ((board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2) || (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2) || (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2))
            {
                return 2;
            }

            //checking for diagonal wins

            else if ((board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2) || (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2))
            {
                return 2;
            }

            //checking for vertical wins

            else if ((board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2) || (board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2) || (board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2))
            {
                return 2;
            }
            return 0;
        }



        public void Player1functions()
        {
            int flag = CheckWhoWon();
            if (flag == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                    {
                        OutPutArray(board);

                        CheckWhoWon();

                        Console.Write("Select your position: ");
                        int position = int.Parse(Console.ReadLine());

                        switch (position)
                        {
                            case 7:
                                board[0, 0] = 1;
                                break;

                            case 8:
                                board[0, 1] = 1;
                                break;

                            case 9:
                                board[0, 2] = 1;
                                break;

                            case 4:
                                board[1, 0] = 1;
                                break;

                            case 5:
                                board[1, 1] = 1;
                                break;

                            case 6:
                                board[1, 2] = 1;
                                break;

                            case 1:
                                board[2, 0] = 1;
                                break;

                            case 2:
                                board[2, 1] = 1;
                                break;

                            case 3:
                                board[2, 2] = 1;
                                break;

                            default:
                                Console.WriteLine("Invalid spot entered");
                                break;
                        }
                    }
                    if (i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        OutPutArray(board);

                        CheckWhoWon();

                        Console.Write("Select your position: ");
                        int position = int.Parse(Console.ReadLine());

                        switch (position)
                        {
                            case 7:
                                board[0, 0] = 2;
                                break;

                            case 8:
                                board[0, 1] = 2;
                                break;

                            case 9:
                                board[0, 2] = 2;
                                break;

                            case 4:
                                board[1, 0] = 2;
                                break;

                            case 5:
                                board[1, 1] = 2;
                                break;

                            case 6:
                                board[1, 2] = 2;
                                break;

                            case 1:
                                board[2, 0] = 2;
                                break;

                            case 2:
                                board[2, 1] = 2;
                                break;

                            case 3:
                                board[2, 2] = 2;
                                break;

                            default:
                                Console.WriteLine("Invalid spot entered");
                                break;

                        }

                    }
                }
            }
            else if (flag == 1)
            {
                Console.WriteLine("Player 1 has won!");
            }
            else
            {
                Console.WriteLine("Player 2 has won!")
            }
        }

        public void Player2Functions()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                {
                    OutPutArray(board);

                    Console.Write("Select your position: ");
                    int position = int.Parse(Console.ReadLine());

                    switch (position)
                    {
                        case 1:
                            board[0, 0] = 2;
                            break;

                        case 2:
                            board[0, 1] = 2;
                            break;

                        case 3:
                            board[0, 2] = 2;
                            break;

                        case 4:
                            board[1, 0] = 2;
                            break;

                        case 5:
                            board[1, 1] = 2;
                            break;

                        case 6:
                            board[1, 2] = 2;
                            break;

                        case 7:
                            board[2, 0] = 2;
                            break;

                        case 8:
                            board[2, 1] = 2;
                            break;

                        case 9:
                            board[2, 2] = 2;
                            break;

                        default:
                            Console.WriteLine("Invalid spot entered");
                            break;
                    }
                }
                if (i == 2 || i == 4 || i == 6 || i == 8)
                {
                    OutPutArray(board);

                    Console.Write("Select your position: ");
                    int position = int.Parse(Console.ReadLine());

                    switch (position)
                    {
                        case 1:
                            board[0, 0] = 1;
                            break;

                        case 2:
                            board[0, 1] = 1;
                            break;

                        case 3:
                            board[0, 2] = 1;
                            break;

                        case 4:
                            board[1, 0] = 1;
                            break;

                        case 5:
                            board[1, 1] = 1;
                            break;

                        case 6:
                            board[1, 2] = 1;
                            break;

                        case 7:
                            board[2, 0] = 1;
                            break;

                        case 8:
                            board[2, 1] = 1;
                            break;

                        case 9:
                            board[2, 2] = 1;
                            break;

                        default:
                            Console.WriteLine("Invalid spot entered");
                            break;

                    }
                }
            }
        }
    
    }
}
