using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService gamerCheckService;

        public bool Check(Gamer gamer)
        {
            gamerCheckService = new MernisServiceAdapter();

            return gamerCheckService.Check(gamer);
        }
    }
}
