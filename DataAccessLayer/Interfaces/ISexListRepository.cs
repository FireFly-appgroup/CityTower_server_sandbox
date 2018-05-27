using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ISexListRepository : IRepository<sex_list>
    {
        void SetSexList(sex_list sexlist);
    }
}
