﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Entities;
using System.Providers;


namespace System.Providers
{

    public class EntityContext : DbContext
    {

        public string ConnectionString = "Server=DESKTOP-SR3QBMC;Database=Source;User=joaom;Integrated Security=True;";
        public EntityContext(DbContextOptions<EntityContext> options)
             : base(options) { }

        public DbSet<Log> Log { get; set; }
        public DbSet<User> User { get; set; }



    }



}



