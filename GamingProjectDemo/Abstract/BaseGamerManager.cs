using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Saved to db : ");
            Console.WriteLine("Adı Soyadı : " + gamer.FirstName + "  " + gamer.LastName);
            Console.WriteLine("TC no. : " + gamer.NationalityId);
            Console.WriteLine("Doğum Tarihi : " + gamer.DateOfBirth);

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted...");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated...");
        }
    }
}
