using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace CityTowerServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new CityTowerDataBase()))
            {
                var productByName = unitOfWork.GoodsList.GetProductByName("Phone");
                sex_list sex = new sex_list();
                sex.sex_id = 2;
                sex.sex = "123";
                unitOfWork.SexList.SetSexList(sex);
                unitOfWork.SexList.Save();
            }
        }
    }
}
