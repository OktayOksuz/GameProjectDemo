using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "----->"+ " Game Added..." + '\n');
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "----->" + " Game Deleted..." + '\n');
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "----->" + " Game Updated..." + '\n');
        }

        
    }
}
