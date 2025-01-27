﻿using SistemaGarcom.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaGarcom.Data
{

    public class ContextApp : DbContext
    {
        public ContextApp()
            : base("SistemaRumo")
        {



        }
        public virtual DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties()
              .Where(p => p.Name == "Id")
              .Configure(p => p.IsKey());


        }


    }
}