using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFramework_WindowsFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcul de toutes ses épargnes durant les trois dernières années

            using (var context = new SavingAccountContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Console.WriteLine("Creation compte et personne");

                var sa1 = new SavingAccount
                {
                    Amount = 2000000, Interest = 0.05, InterestInterval = 1
                };


                var sa2 = new SavingAccount
                {
                    Amount = 250000, Interest = 0.15, InterestInterval = 12
                };

                var sa3 = new SavingAccount
                {
                    Amount = 10000000, Interest = 0.02, InterestInterval = 12
                };

                var person = new Person
                {
                    Name = "Mr.Richards",
                    ListSavingAccount = new List<SavingAccount> { sa1,sa2,sa3 }
                };

                Console.WriteLine("fin création");

                DateTime begin = new DateTime(2019, 01, 01);
                DateTime end = new DateTime(2021, 12, 31);

                context.Add(person);
                context.SaveChanges();

                Console.WriteLine("Total Epargne");

                Console.WriteLine(SavingCalculator.CalculateTotalSaved(begin, end, person.ListSavingAccount));

                /*double newAmount = sa1.Amount + (sa1.Amount * sa1.Interest) *36 ;
                Console.WriteLine(newAmount);

                double newAmount2 = sa2.Amount + (sa2.Amount * sa2.Interest) *3;
                Console.WriteLine(newAmount2);

                double newAmount3 = sa3.Amount + (sa3.Amount * sa3.Interest)*3;
                Console.WriteLine(newAmount3);

                Console.WriteLine(newAmount + newAmount2 + newAmount3);*/


                //calcul de toutes ses épargnes durant les trois dernières années




            }
        }
    }
}
