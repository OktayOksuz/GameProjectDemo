using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GamerManager : IGamerService
    {

        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine("Gamer added..." + '\n');
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Verification failed... TRY AGAİN!");
                
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "  " + "Gamer Deleted...");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "  " + "Gamer Updated...");
            }
            else
            {
                Console.WriteLine("Verification failed... TRY AGAİN!");
            }
        }
    }
}
