using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IGoodsListRepostirory : IRepository<eshop_goods_list>
    {
        IEnumerable<eshop_goods_list> GetProductByName(string ProductName);
    }
}
