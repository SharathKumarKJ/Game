using System;

namespace Games.Classes
{
    class CardGame : IGame<int>
    {
        public void Play(int value)
        {
            var cardDetails = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            var rand = new Random();

            var cardPicked = rand.Next(4);

            switch (cardPicked)
            {
                case 0:
                    Console.WriteLine("Clubs : " + FindCard(value, cardDetails));
                    break;
                case 1:
                    Console.WriteLine("Diamonds : " + FindCard(value, cardDetails));
                    break;
                case 2:
                    Console.WriteLine("Hearts : " + FindCard(value, cardDetails));
                    break;
                case 3:
                    Console.WriteLine("Spades : " + FindCard(value, cardDetails));
                    break;

            }
        }

        private string FindCard(int value, string[] cardDetails)
        {
            var randGenerator = value / 13;
            var cardPicked = cardDetails[randGenerator];
            return cardPicked;
        }

      

        public void ReArrage()
        {
            Console.WriteLine("Card has been Re-Arraged");
        }

        public void ReStart()
        {
            Console.WriteLine("Game has been Re-Started Successfully....");
        }

        public void Exit()
        {
            Console.WriteLine("Game is Exiting.....");
            
        }
    }
}
