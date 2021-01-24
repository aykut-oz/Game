using Game.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.AppServices
{
    class GameService : IGameService
    {
        public void Create(Game game)
        {
            Console.WriteLine("Game {0} added.",game.Name);
        }

        public void Delete(long gameId)
        {
            if (gameId>0)
            {
                Console.WriteLine("Game Deleted.");
            }
        }

        public void Update(Game game)
        {
            
        }
    }
}
