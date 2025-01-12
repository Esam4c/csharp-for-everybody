using System;

namespace RockPaperScissors
{
    class Program
    {
        enum Move { Rock, Paper, Scissors }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");

            while (true)
            {
                Move playerMove = GetPlayerMove();
                Move computerMove = GetComputerMove();

                Console.WriteLine($"Computer played {computerMove}");

                DetermineWinner(playerMove, computerMove);

                Console.WriteLine("Play again? (yes/no): ");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }
            }
        }

        static Move GetPlayerMove()
        {
            while (true)
            {
                Console.WriteLine("Enter your move (rock, paper, or scissors): ");
                string playerInput = Console.ReadLine().ToLower();

                switch (playerInput)
                {
                    case "rock":
                        return Move.Rock;
                    case "paper":
                        return Move.Paper;
                    case "scissors":
                        return Move.Scissors;
                    default:
                        Console.WriteLine("Invalid move. Please try again.");
                        break;
                }
            }
        }

        static Move GetComputerMove()
        {
            Random rand = new Random();
            return (Move)rand.Next(3);
        }

        static void DetermineWinner(Move playerMove, Move computerMove)
        {
            if (playerMove == computerMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == Move.Rock && computerMove == Move.Scissors) ||
                     (playerMove == Move.Paper && computerMove == Move.Rock) ||
                     (playerMove == Move.Scissors && computerMove == Move.Paper))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}

