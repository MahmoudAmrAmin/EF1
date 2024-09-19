using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_SetupEFCoreModle
{
    // Summary:
    //     A DbContext instance represents a session with the database and can be used to
    //     query and save instances of your entities. DbContext is a combination of the
    //     Unit Of Work and Repository patterns.
    internal class DigitalCurrencyDbContext:DbContext
    {

        DbSet<Wallet> Wallets { get; set; } = null!; 
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);    

            var configuration = new ConfigurationBuilder()
                                .AddJsonFile("appSettings.json").
                                Build();

            var connectionString = configuration.GetSection("constr").Value;
            


            // this statment allow you to use data provider (sql server) 
            dbContextOptionsBuilder.UseSqlServer(connectionString);


        }
    }
}
