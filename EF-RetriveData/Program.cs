using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.EntityFrameworkCore; 

namespace EF_RetriveData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use Dispose method when i context with data base 

            using (var context = new DigitalCurrencyDbContext())
            {
                foreach( var wallet in context.Wallets)
                {
                    Console.WriteLine( wallet);
                }



            }

            // after this Curly brackets context with database will dispose 





        }
    }
}
