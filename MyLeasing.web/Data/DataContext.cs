using System;
using Microsoft.EntityFrameworkCore;
using MyLeasing.web.Data.Entities;

namespace MyLeasing.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }

    }
}
