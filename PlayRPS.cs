/* 

Rock paper scissors program by a very cool dude
created on 09/03/2025
1.0 - 9/3/25
1.1 - 9/30/25

*/

using System;
using System.Threading;

namespace RPSsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock paper scissors v1.1");
            Console.WriteLine();
            // establish variables and arrays

            string[] ValidMoves = {"rock", "paper", "scissors"};
            Random random = new Random();
            int OtherChooser = 0;
            int count = 0;
            int wins = 0;
            int losses = 0;
            int ties = 0;

            string OtherMove = "none";
            string PlayerMove = "none";
            string PlayerInput = "none";
            string OutPut = "none";
            
            bool IsValid = false;



            // Main gameplay loop

            while (true)
            {
                Thread.Sleep(1000);
                count = count + 1; // increase count
                Console.WriteLine(); // tidy up
                Console.WriteLine(count + "."); // Show count
                Thread.Sleep(300);
                Console.WriteLine("Your move:");
            

                OtherChooser = random.Next(1, 4); // randomize move
                PlayerInput = Console.ReadLine(); // get player move

                // check if move is valid (Code warning)
                if (PlayerInput == ValidMoves[0])
                {
                    IsValid = true;
                }
                else if (PlayerInput == ValidMoves[1])
                {
                    IsValid = true;
                }
                else if (PlayerInput == ValidMoves[2])
                {
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                }

                
                if (IsValid == true)
                {
                    // out of sight
                    for (int i = 0; i < 120; i++)
                    {
                        Console.WriteLine();
                    }
                    //end

                    // Set computer move according to chosen random number
                    switch (OtherChooser)
                    {
                        case 1:
                            OtherMove = "paper";
                            break;

                        case 2:
                            OtherMove = "rock";
                            break;

                        case 3:
                            OtherMove = "scissors";
                            break;
                    }

                    // set player move to chosen move
                    PlayerMove = PlayerInput;
                    //

                    Console.WriteLine();
                    Console.WriteLine("You: " + PlayerMove + "  |  Computer: " + OtherMove);
                    Thread.Sleep(500)

                    // Main logic of wins, losses, and ties

                    switch (PlayerMove) // get player move
                    {
                        case "rock": // if player use rock
                        switch (OtherMove) // use according action
                        {
                            case "rock":
                            OutPut = "tie";
                            break;

                            case "paper":
                            OutPut = "loss";
                            break;

                            case "scissors":
                            OutPut = "win";
                            break;
                        }
                        break;

                        case "paper": // if player use paper
                        switch (OtherMove) // use according action
                        {
                            case "rock":
                            OutPut = "win";
                            break;

                            case "paper":
                            OutPut = "tie";
                            break;

                            case "scissors":
                            OutPut = "loss";
                            break;
                        }
                        break;

                        case "scissors": // if player use scissors
                        switch (OtherMove) // use according action
                        {
                            case "rock":
                            OutPut = "loss";
                            break;

                            case "paper":
                            OutPut = "win";
                            break;

                            case "scissors":
                            OutPut = "tie";
                            break;
                        }
                        break;
                    }
                    
                    // change stuff depending on what the output was
                    switch (OutPut)
                    {
                        case "win":
                        wins = wins + 1;
                        Console.WriteLine("win");
                        break;

                        case "loss":
                        losses = losses + 1;
                        Console.WriteLine("loss");
                        break;

                        case "tie":
                        ties = ties + 1;
                        Console.WriteLine("tie");
                        break;
                    }

                    Console.WriteLine(); // shows stats of wins losses and ties
                    Console.WriteLine("W: " + wins);
                    Console.WriteLine("L: " + losses);
                    Console.WriteLine("T: " + ties);

                }

                else
                {
                    Console.WriteLine("Please play a vlid move."); // you tell 'em jeorge
                }
            }
        }
    }
}