using E_Trade.Business.Concreate;
using E_Trade.DAL.Abstract;
using E_Trade.Data.DbContext;
using E_Trade.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.DAL.Concreate
{
    public class CategoryDAL:GenericRepository<Category, E_TradeContext>, ICategoryDAL
    {

    }
}
