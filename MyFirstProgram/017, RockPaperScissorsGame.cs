class RockPaperScissors
{
    static void Main(string[] args)
    {
        Random random = new();
        bool playAgain = true;

        while (playAgain)
        {
            string player = "";
            string computer = "";

            // Get valid player input
            while (player != "rock" && player != "paper" && player != "scissors")
            {
                Console.Write("Enter rock, paper, or scissors: ");
                player = Console.ReadLine().ToLower();
            }

            // Computer choice
            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "rock";
                    break;
                case 2:
                    computer = "paper";
                    break;
                default:
                    computer = "scissors";
                    break;
            }

            Console.WriteLine("Computer chose: " + computer);

            // Game logic
            if (player == computer)
            {
                Console.WriteLine("It's a draw");
            }
            else if (
                (player == "rock" && computer == "paper") ||
                (player == "paper" && computer == "scissors") ||
                (player == "scissors" && computer == "rock")
            )
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }

            // Play again loop
            while (true)
            {
                Console.Write("Do you want to play again? (y/n): ");
                string playingAgain = Console.ReadLine().ToLower();

                if (playingAgain == "y")
                {
                    break; // start new round
                }
                else if (playingAgain == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    playAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter y or n.");
                }
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
