﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MT.GridView.Models
{    
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Customer>().Property(c => c.CompanyName).HasMaxLength(40);
            modelBuilder.Entity<Customer>().Property(c => c.ContactTitle).HasMaxLength(40);
        }
    }
}