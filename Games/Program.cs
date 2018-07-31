using Games.FactoryClasses;
using System;

namespace Games
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            StartGame();
        }

        private static void StartGame()
        {

            var gameType = 0;
            var logType = 0;

            var log = Factory.CreateLogInstace(logType);

            Console.WriteLine("====================");
            Console.WriteLine("Welcome Games Portal");
            Console.WriteLine("1 For Card Game");
            Console.WriteLine("2 For Cricket Game");
            try
            {

                gameType = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ex)
            {
                log.LogError(ex.Message + ex.StackTrace);
            }

            switch (gameType)
            {
                case 1:
                    CardGame(gameType);
                    break;
                case 2:
                    CricketGame(gameType);
                    break;
            }
        }

        private static void CardGame(int gameType)
        {
            var cardCount = default(int);
            var IsGameOver = false;

            for (; ; )
            {
                if (cardCount < 52)
                {
                    Console.WriteLine("1 For Play");
                    Console.WriteLine("2 For Re-Arranage");
                    Console.WriteLine("3 For Re-Start");
                    Console.WriteLine("4 For Exit");
                }
                else
                {
                    Console.WriteLine("3 For Re-Start");
                    Console.WriteLine("4 For Exit");
                    IsGameOver = true;

                }

                var userEnteredOption = default(int);

                var game = Factory.CreateGameInstace(gameType - 1);

                try
                {
                    userEnteredOption = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enterd value is not valid. more information :" + ex.Message);
                }

                if (IsGameOver && cardCount >= 52 && userEnteredOption == 3)
                {
                    cardCount = 0;
                }
                if (userEnteredOption == 4)
                {
                    break;
                }
                if (IsGameOver && (userEnteredOption != 3 || userEnteredOption != 4))
                {
                    continue;
                }

                var randomNumberGenerator = new Random();
                var value = randomNumberGenerator.Next(52);

                switch (userEnteredOption)
                {
                    case 1:
                        Console.WriteLine("Your Card :");
                        game.Play(value);
                        cardCount++;
                        break;
                    case 2:
                        Console.WriteLine("Shuffle Card... ");
                        game.ReArrage();
                        break;
                    case 3:
                        Console.WriteLine("Game Re-Start...");
                        game.ReStart();
                        break;
                    case 4:
                        Console.WriteLine("Game Exit....");
                        game.Exit();
                        break;
                    default:
                        Console.WriteLine("Please Enter valid Option....");
                        break;

                }
                Console.WriteLine("Card Count :" + cardCount);
            }
        }

        private static void CricketGame(int gameType)
        {
            Console.WriteLine("Game development is in progress.....");
        }
    }
}
