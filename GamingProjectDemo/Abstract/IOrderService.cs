using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IOrderService
    {
        void Order(Gamer gamer, Game game);
        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
           
    }
}
