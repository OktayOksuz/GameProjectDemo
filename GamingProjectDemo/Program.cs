using GameProjectDemo;
using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer = new Gamer
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 05, 14),
                FirstName = "DAMLA",
                LastName = "GENÇ",
                NationalityId = 12345
            };
            gamerManager.Add(gamer);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign {CampaignId = 1, CampaignName = "%50 İNDİRİM", DiscountRate = 0.50M };
            campaignManager.Add(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game {GameId = 1, GameName = "TETRIS ", GamePrice = 180 };
            gameManager.Add(game);

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer, game);
            orderManager.CampaignOrder(game, gamer, campaign);

        }
    }
}
