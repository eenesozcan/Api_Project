using Api_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Project.DAL
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CSTSJL1\\MSSQLSERVER2019;initial catalog=ZApiDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }


    }
}
