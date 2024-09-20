using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json; 
namespace EF_RetriveSingleItem
{
    internal class DigitalCurrencyDbContext : DbContext
    {
        public DbSet<Walltes> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("DigitalCurrencySetting.json")
                .Build();

            var connectionString = configuration.GetSection("constr").Value; 
            


            optionsBuilder.UseSqlServer(connectionString);







        }







    }
}
