using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces.Service
{
    interface IGameService
    {
        void Create(Game game);
        void Update(Game game);
        void Delete(long gameId);
    }
}
