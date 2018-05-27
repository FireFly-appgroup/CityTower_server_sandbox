using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityTowerDataBase _context;

        public UnitOfWork(CityTowerDataBase context)
        {
            _context = context;
            GoodsList = new GoodsListRepository(_context);
            SexList = new SexListRepository(_context);
        }

        public IGoodsListRepostirory GoodsList { get; private set; }
        public ISexListRepository SexList { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
