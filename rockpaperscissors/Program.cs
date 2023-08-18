//```cs
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;

        while (playAgain)
        {
            player = "";
            computer = "";
            answer = "";

            while (player != "ROCK" &&player != "PAPER" &&player != "!SCISSORS")
            {
              Console.Write("ROCK, PAPER OR SCISSORS SHOOT!: ");
              player = Console.ReadLine();
              player = player.ToUpper();
            }
            
            
            switch (random.Next(1, 4))
            {
               case 1:
                    computer = "ROCK";
                    break;
               case 2:
                    computer = "PAPER";
                    break;
               case 3:
                    computer = "SCISSORS";
                    break;
            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch(player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (computer == "PAPER" )
                    {
                        Console.WriteLine("You lose");
                    }
                    else
                    {
                        Console.WriteLine("You win!!");
                    }
                    break;
                case "PAPER":
                    if (computer == "PAPER")
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (computer == "SCISSORS" )
                    {
                        Console.WriteLine("You lose");
                    }
                    else
                    {
                        Console.WriteLine("You win!!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "SCISSORS")
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (computer == "ROCK" )
                    {
                        Console.WriteLine("You lose");
                    }
                    else
                    {
                        Console.WriteLine("You win!!");
                    }
                    break;
            }

            Console.WriteLine("Would you like to play again?(Y/N): ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;
            }

            else
            {
                playAgain = false;
            }

            Console.WriteLine("Thanks for playing!!! Have a good day :)");

            Console.ReadKey();
        }
    }
}
//```cs