using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer.Repositories
{
    public class GoodsListRepository : Repository<eshop_goods_list>, IGoodsListRepostirory
    {
        public GoodsListRepository(CityTowerDataBase context) : base(context)
        {
        }

        public IEnumerable<eshop_goods_list> GetProductByName(string ProductName)
        {
            return CityTowerDataBase.eshop_goods_list.Where(t => t.goods_name == ProductName).ToList();
        }

        public CityTowerDataBase CityTowerDataBase
        {
            get { return Context as CityTowerDataBase; }
        }
    }
}
