using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class OrderManager : IOrderService
    {
        //damla buys a game for .... liras
        //The game named x was sold to damla at a discount
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal discaountSales = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine( game.GameName + " " +" was sold to " + gamer.FirstName + " " + gamer.LastName +" with "
                + campaign.CampaignName +" discount for "
                + " " + discaountSales +
                " liras." + '\n' );
        }

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName +" buys a "+ game.GameName + " " + game.GamePrice + " liras.");
        }
    }
}
