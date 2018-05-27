using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SexListRepository : Repository<sex_list>, ISexListRepository
    {
        public SexListRepository(CityTowerDataBase context) : base(context)
        {
        }

        public void SetSexList(sex_list sexlist)
        {
            CityTowerDataBase.sex_list.Add(sexlist);
        }

        public CityTowerDataBase CityTowerDataBase
        {
            get { return Context as CityTowerDataBase; }
        }
    }
}