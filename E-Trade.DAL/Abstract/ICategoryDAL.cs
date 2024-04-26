using E_Trade.Business.Abstract;
using E_Trade.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.DAL.Abstract
{
    public interface ICategoryDAL : IGenericRepository<Category>
    {
    }
}
