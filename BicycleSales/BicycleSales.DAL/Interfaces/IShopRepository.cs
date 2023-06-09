using BicycleSales.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleSales.DAL.Interfaces
{
    public interface IShopRepository
    {
        public Task<ShopDto> CreateNewShop(ShopDto shop);
        public Task<IEnumerable<ShopDto>> GetAllShops();
        public Task<ShopDto> GetShopById(int id);
        public bool IsShopExist(int id);
        public Task<IEnumerable<ShopProductDto>> GetAllProductsByShopId(int id);
        public Task<ShopProductDto> AddProductInShopAsync(ShopProductDto shop);
        public Task<ShopProductDto> DeleteProductCountInShopAsync(ShopProductDto shopProductDto);
    }
}
