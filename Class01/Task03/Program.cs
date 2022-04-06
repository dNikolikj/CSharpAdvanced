using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {

            //3.Create a console application that plays rock -paper - scissors - BONUS🔹
            //There should be a menu with three options:
            //Play
            //The user picks rock paper or scissors option(rock, paper or scissors as strings)
            //The application picks rock paper scissors on random
            //The user pick and the application pick are shown on the screen
            //The application shows the winner
            //The application saves 1 score to the user or the computer in the background
            //When the user hits enter it returns to the main menu
            //Stats
            //It shows how many wins the user and how many wins the computer has
            //It shows percentage of the wins and loses of the user
            //When the user hits enter it returns to the main menu
            //Exit
            //It closes the application

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
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS:");
                    player = Console.ReadLine().ToUpper();

                }
                /*int randomNum = random.Next(1, 4);*/// generate betweem  1-3
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
                Console.WriteLine("Player:" + player);
                Console.WriteLine("Computer:" + computer);
               
                switch(player)
                {
                    case "ROCK":
                        if(computer == "ROCK") { 
                            Console.WriteLine("It's a draw.");
                        } else if(computer == "PAPER")
                        {
                            Console.WriteLine("You loose!");

                        } else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You loose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw.");

                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You loose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");

                        }
                        else
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        break;
                }
                Console.Write("Would you like to play again?\n y/n ");
                answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Goodbye and thanks for playing!");

        }
    }
}
