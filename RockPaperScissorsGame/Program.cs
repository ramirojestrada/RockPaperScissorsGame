using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            string ComputerAnswer;
            string UserAnswer;


            while (PlayAgain)
            {
                UserAnswer = "";
                ComputerAnswer = "";
                while (UserAnswer != "ROCK" && UserAnswer != "PAPER" && UserAnswer != "SCISSORS")
                {
                    System.Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    UserAnswer = Console.ReadLine();
                    UserAnswer = UserAnswer.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        ComputerAnswer = "ROCK";
                        break;

                    case 2:
                        ComputerAnswer = "PAPER";
                        break;

                    case 3:
                        ComputerAnswer = "SCISSORS";
                        break;
                }

                System.Console.WriteLine("Player: {0}", UserAnswer);
                System.Console.WriteLine("Computer: {0}", ComputerAnswer);


                switch (UserAnswer)
                {
                    case "ROCK":
                        if (ComputerAnswer == "ROCK")
                        {
                            System.Console.WriteLine("It's a draw!");
                        }
                        else if (ComputerAnswer == "PAPER")
                        {
                            System.Console.WriteLine("You lose");
                        }
                        else
                        {
                            System.Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (ComputerAnswer == "ROCK")
                        {
                            System.Console.WriteLine("You win!");
                        }
                        else if (ComputerAnswer == "PAPER")
                        {
                            System.Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose");
                        }
                        break;
                    case "SCISSORS":
                        if (ComputerAnswer == "ROCK")
                        {
                            System.Console.WriteLine("You lose!");
                        }
                        else if (ComputerAnswer == "PAPER")
                        {
                            System.Console.WriteLine("You win!");
                        }
                        else
                        {
                            System.Console.WriteLine("It's a draw!");
                        }
                        break;
                }


            }


        }
    }
}