using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu Satın Alındı" + "Fiyatı:" + game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu Silindi" );
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu Güncellendi");
        }
    }
}
