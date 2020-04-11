using Microsoft.AspNetCore.SignalR;
using Shop.Server.EF;
using Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Server.SignalR
{
    public class ShopingCart : Hub
    {
        public async void PrimiIteme(Artikal v)
        {
            DataBase koka = new DataBase();
            koka.Add(v);           
            koka.SaveChanges();
            Console.WriteLine($"Sacuvani Artikal {v}");
        }
	}
}
