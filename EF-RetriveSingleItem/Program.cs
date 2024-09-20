using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Console;


namespace EF_RetriveSingleItem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region retrive one item
            /*int itemIdToRetrive = 3;

            using (var context = new DigitalCurrencyDbContext())
            {

                Console.WriteLine(context.Wallets.FirstOrDefault( wallet => wallet.Id == itemIdToRetrive));
                


            }*/
            #endregion

            #region insert data

            /*Walltes wallet = new Walltes
            {
                Holder = "amr",
                Balance = 1800000m
            };

            using (var context = new DigitalCurrencyDbContext())
            {

                context.Wallets.Add(wallet);
                context.SaveChanges();  

                foreach( var Wallet in context.Wallets )
                {
                    Console.WriteLine(Wallet);
                }
                    

                   

            }*/

            #endregion

            #region Update data 
            // update id number  4
            // 

            /*using (var context = new DigitalCurrencyDbContext())
            {

                var wallet = context.Wallets.SingleOrDefault( wallet => wallet.Id == 4) ??new();

                wallet.Balance += 150000m; 
                

                // save changes in sql server database 

                context.SaveChanges();





            }*/
            #endregion


            #region Delete data

            // delete item  with id   7 
            /*using (var context = new DigitalCurrencyDbContext())
            {

                var wallet = context.Wallets.SingleOrDefault(wallet => wallet.Id == 7) ?? new();

                context.Wallets.Remove(wallet); 

                // save changes in sql server database 

                context.SaveChanges();





            }*/

            #endregion


            #region Query data
            /*using (var context = new DigitalCurrencyDbContext())
            {

                var wallet = context.Wallets.Where(wallet => wallet.Balance > 150000m).ToList(); 

                foreach( var wallets in wallet)
                {
                    Console.WriteLine(wallets.ToString());
                }

                context.SaveChanges();




            }*/
            #endregion


            #region Implement Transaction
            using (var context = new DigitalCurrencyDbContext()) 
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    // transfer 150000 form id : 4 to id :1

                    var fromWallet = context.Wallets.FirstOrDefault(x => x.Id == 4);

                    var toWallet = context.Wallets.FirstOrDefault(y => y.Id == 1);

                    //first operation : withdraw from id 4 
                    fromWallet.Balance -= 150000m;

                    context.SaveChanges();

                    //second operation : Deposit to second wallet

                    toWallet.Balance += 150000m;
                    context.SaveChanges(); 


                    transaction.Rollback();
                    
                }
            
            
            
            }
            
            #endregion


        }
    }
}
