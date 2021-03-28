using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game guessGame = new Game();
            guessGame.Start();
            string response = "";
            while (response != "yes" || response != "no")
            {
            Console.Write("Wanna play again?(Write yes or no)");
            response = Console.ReadLine();
                if (response == "yes")
                {
                    guessGame.Start();
                }
                else if (response == "no")
                {
                    guessGame.End();
                    break;
                }
            }
        }
        class Game
        {
            public void Start()
            {
                Random r = new Random();
                int winNum = r.Next(0, 100);
                bool win = false;
                do
                {
                    Console.Write("Guess a number inbetween 0 and 100: ");
                    string response = Console.ReadLine();
                    int intResponse;
                    bool isNumerical = int.TryParse(response, out intResponse);
                    if (isNumerical)
                    {
                        if (intResponse > winNum)
                        {
                            Console.WriteLine("To high! Guess lower...");
                        }
                        else if (intResponse < winNum)
                        {
                            Console.WriteLine("To low! Guess higher...");
                        }
                        else if (intResponse == winNum)
                        {
                            Console.WriteLine("YOU WIN!");
                            win = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Write a number");
                    }
                } while (win == false);
            }
            public void End()
            {
                Console.WriteLine("Thank you for playing the game");
                Console.Write("Press any key to finish.");
            }
        }
    }
}
