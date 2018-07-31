using Games.Classes;
using Games.Interfaces;
using System.Collections.Generic;

namespace Games.FactoryClasses
{
    public static class Factory
    {
        private static List<IGame<int>> gameList = null;

        private static List<ILog<string>> logList = null;

        public static IGame<int> CreateGameInstace(int gameIndex)
        {
            if (gameList == null)
            {
                gameList = new List<IGame<int>>
                {
                    new CardGame()
                };
            }

            return gameList[gameIndex];

        }

        public static ILog<string> CreateLogInstace(int logIndex)
        {
            if (logList == null)
            {
                logList = new List<ILog<string>>
                {
                    new ConsoleLog(),
                    new FileLog(),
                    new DataBaseLog()
                };
            }
            return logList[logIndex];

        }

    }
}
