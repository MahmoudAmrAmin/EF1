using Microsoft.Extensions.Configuration;

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
