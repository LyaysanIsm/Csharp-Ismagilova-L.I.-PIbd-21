﻿using ForgeShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopDatabaseImplement
{
    public class ForgeShopDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-0755RO83\SQLEXPRESS;Initial Catalog=ForgeShopHmDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Billet> Billets { set; get; }
        public virtual DbSet<ForgeProduct> ForgeProducts { set; get; }
        public virtual DbSet<ForgeProductBillet> ForgeProductBillets { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Storage> Storages { set; get; }
        public virtual DbSet<StorageBillet> StorageBillets { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
    }
}