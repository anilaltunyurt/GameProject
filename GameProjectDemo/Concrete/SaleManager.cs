using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
   class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + "Oyunu" + gamer.FirstName + "Tarafından" + campaign.CampaignName + "Kampanyası ile Alınmıştır");
        }
    }
}
