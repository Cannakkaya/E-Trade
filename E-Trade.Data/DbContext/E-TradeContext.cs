using E_Trade.Data.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Data.DbContext
{
    public class E_TradeContext : IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ETradeDb;User Id=sa;Password=1234;TrustServerCertificate=true;");
        }
    }
}
