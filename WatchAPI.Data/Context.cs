using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WatchAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

        //public DbSet<ImageEntity> Images { get; set; }
    }
}
