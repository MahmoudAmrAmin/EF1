using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json; 
using  Microsoft.EntityFrameworkCore;
using System;
using static System.Console; 

namespace EF_SetupEFCoreModle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder ()
                                .AddJsonFile("appSettings.json").
                                Build ();

            var connectionString = configuration.GetSection("constr").Value;

            Console.WriteLine(connectionString);

        }
    }
}
