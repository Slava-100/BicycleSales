﻿using BicycleSales.DAL.Contexts;
using BicycleSales.DAL.Interfaces;
using BicycleSales.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleSales.DAL
{
    public class ShopRepository : IShopRepository
    {
        private readonly Context _context;

        public ShopRepository(Context context = null)
        {
            _context = context ?? new Context();
        }

        public ShopDto CreateNewShop(ShopDto shop)
        {
            if (_context.Shops.ToList().Find(s => s.Location == shop.Location) is not null)
            {
                throw new Exception($"Магазин с таким Location:{shop.Location} уже существует");
            }
            else
            {
                _context.Shops.Add(shop);
                _context.SaveChanges();

                return _context.Shops.Single(s => s.Id == shop.Id);
            }
        }
    }
}
