using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EntityFramework_WindowsFrom
{
    class SavingAccountContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<SavingAccount> SavingsAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=Essai;Integrated Security=True");
        }

    }
}
